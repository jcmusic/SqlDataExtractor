using Azure.Storage.Blobs;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YuStashSageX3_ETL.Helpers;
using YuStashSageX3_ETL.Models;


namespace YuStashSageX3_ETL
{
    interface IDataExtractor
    {
        Task ExtractDataAndUploadCsv();
    }

    internal class DataExtractor : IDataExtractor
    {
        public DataExtractor()
        { }

        public async Task<bool> Test_DataSource_Connection()
        {
            var transactionId = Guid.NewGuid();
            var fileExtension = ".csv";
            var fileName = $"{transactionId}{fileExtension}";
            var sqlStatement = "Select top 10 * FROM ZOMNI_BOM_MASTER;";
            //var sqlExecStringParams = $"'{transactionId}', '{fileName}'";

            MemoryStream ms = await GetSqlDataStreamAsync<Vw_Bom_Master>(transactionId, sqlStatement);
            await StreamToAzureBlobFileAsync(ms, fileName, transactionId);
            Console.WriteLine($"{fileName} uploaded.");

            try
            {
                //var MsgQueue = new MessageQueueService();
                //await MsgQueue.ExecuteStoredProcedureAsync(sqlExecStringParams, Constants.OMNI_DB_SP_NAME, transactionId);
                ////_logger.LogInformation($"{transactionId} - [etl].[sp_BulkInsert_InventoryReceipt] call sent to MessageQueue");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //_logger.LogError($"{transactionId}: {e.Message}");
            }

            return true;
        }

        public async Task ExtractDataAndUploadCsv()
        {
            await SyncData<Vw_Bom_Master>("ZOMNI_BOM_MASTER");
            await SyncData<Vw_Customer_Master>("ZOMNI_CUSTOMER_MASTER");
            await SyncData<Vw_Item_Master>("ZOMNI_ITEM_MASTER");
            await SyncData<Vw_Sales_Orders>("ZOMNI_SALES_ORDERS");
            await SyncData<Vw_Shipping_Confirmation>("ZOMNI_SHIPPING_CONFIRMATION");
            await SyncData<Vw_Supplier_Constraints>("ZOMNI_SUPPLIER_CONSTRAINTS");
            await SyncData<Vw_Supplier_Master>("ZOMNI_SUPPLIER_MASTER");
            await SyncData<Vw_Warehouse_Master>("ZOMNI_WAREHOUSE_MASTER");
            Console.WriteLine();
            Console.WriteLine("Data extraction complete.");
        }

        #region Private

        private async Task SyncData<T>(string viewName) where T : class
        {
            #region locals
            var transactionId = Guid.NewGuid();
            var fileExtension = ".csv";
            var fileName = $"{transactionId}{fileExtension}";
            var sqlStatement = $"Select * FROM {viewName};";
            var sqlExecStringParams = $"'{transactionId}', '{fileName}', '{viewName}'";
            #endregion

            try
            {
                MemoryStream ms = await GetSqlDataStreamAsync<T>(transactionId, sqlStatement);
                await StreamToAzureBlobFileAsync(ms, fileName, transactionId);
                Console.WriteLine($"{fileName} uploaded.");

                var MsgQueue = new MessageQueueService();
                await MsgQueue.ExecuteStoredProcedureAsync(sqlExecStringParams, Constants.OMNI_DB_SP_NAME, transactionId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //_logger.LogError($"Error during DataSync for {viewName} : {e.Message}");
                throw;
            }
        }

        private async Task<MemoryStream> GetSqlDataStreamAsync<T>(Guid transactionId, string sqlStatement) where T : class
        {
            var list = new List<ICreatable<T>>();
            Console.WriteLine();
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine($"{typeof(T).FullName}");

            ICreatable<T> createableInstance = GetICreatableInstance<T>();

            var memory = new MemoryStream();
            var writer = new StreamWriter(memory) { AutoFlush = true };
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.ShouldQuote = args => true;

            try
            {
                using (var conn = new SqlConnection(Constants.YUSTASH_SOURCE_DB_CXN_STRING))
                using (var command = new SqlCommand(sqlStatement, conn)
                {
                    CommandType = CommandType.Text,
                    CommandText = sqlStatement,
                    CommandTimeout = 1800  //30 min = 1800 sec
                })
                {
                    await conn.OpenAsync();

                    using (SqlDataReader dataReader = await command.ExecuteReaderAsync())
                    {
                        if (dataReader.HasRows)
                        {
                            while (await dataReader.ReadAsync())
                            {
                                list.Add((ICreatable<T>)createableInstance.Create(dataReader, transactionId));
                            }
                        }
                        else
                        {
                            Console.WriteLine($"0 rows returned for '{sqlStatement}'.");
                        }

                        dataReader.Close();
                    }

                    Console.WriteLine($"{list.Count} rows returned.");
                    return await ConvertListToStream<T>(list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error while querying YuStash data {sqlStatement}: {e.Message}");
                //_logger.LogError($"Error while querying YuStash data {sqlStatement}: {e.Message}");
                throw;
            }
        }

        private async Task StreamToAzureBlobFileAsync(MemoryStream memoryStream, string fileName, Guid transactionId)
        {
            try
            {
                await UploadClientFile(memoryStream, fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine($"File upload failed. TransactionId = {transactionId}");
                Console.WriteLine(e.Message);
                //_logger.LogError(e.Message, e);
                throw;
            }
        }

        private async Task UploadClientFile(Stream stream, string fileName)
        {
            var container = GetStorageContainer(Constants.CdnClientFileUploadContainer);
            var blockBlob = container.GetBlobClient(fileName);
            await blockBlob.UploadAsync(stream);
        }

        private BlobContainerClient GetStorageContainer(string containerName) =>
            new BlobServiceClient(Constants.CdnConnectionString).GetBlobContainerClient(containerName);

        private async Task<MemoryStream> ConvertListToStream<T>(List<ICreatable<T>> list)
        {
            string SEPARATION_CHAR = ",";

            MemoryStream ms = new MemoryStream();

            using (StreamWriter sw = new StreamWriter(ms, new UTF8Encoding(false), 8192, true))
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                var headerline = string.Join(SEPARATION_CHAR, properties.OrderBy(x => x.Name).Select(x => x.Name));
                //Console.WriteLine(headerline);

                await sw.WriteLineAsync(headerline);

                foreach (var model in list)
                {
                    var s = string.Join(SEPARATION_CHAR, properties.OrderBy(x => x.Name).Select(prop => prop.GetValue(model)));
                    //Console.WriteLine(s);
                    //var escaped = StringHelper.Escape(s);
                    //Console.WriteLine(StringHelper.Escape(s));
                    await sw.WriteLineAsync(s);
                }
            }

            ms.Position = 0;
            return ms;
        }

        private async Task BulkLoadList<T>(List<ICreatable<T>> list)
        {
            
            //using (var bulkCopy = new SqlBulkCopy(connectionString))
            //{
            //    bulkCopy.BulkCopyTimeout = 600;
            //    bulkCopy.DestinationTableName = "staging.Staging_BOM_Master";
            //    bulkCopy.WriteToServer(reader);
            //}



            ////string SEPARATION_CHAR = ",";
            //string SEPARATION_CHAR = "|";

            //MemoryStream ms = new MemoryStream();

            //using (StreamWriter sw = new StreamWriter(ms, new UTF8Encoding(false), 8192, true))
            //{
            //    PropertyInfo[] properties = typeof(T).GetProperties();
            //    var headerline = string.Join(SEPARATION_CHAR, properties.OrderBy(x => x.Name).Select(x => x.Name));
            //    //Console.WriteLine(headerline);

            //    await sw.WriteLineAsync(headerline);

            //    foreach (var model in list)
            //    {
            //        var s = string.Join(SEPARATION_CHAR, properties.OrderBy(x => x.Name).Select(prop => prop.GetValue(model)));
            //        Console.WriteLine(s);
            //        //var escaped = StringHelper.Escape(s);
            //        //Console.WriteLine(StringHelper.Escape(s));
            //        await sw.WriteLineAsync(s);
            //    }
            //}

            //ms.Position = 0;
            //return ms;
        }

        private static ICreatable<T> GetICreatableInstance<T>() where T : class
        {
            Type type = Type.GetType(typeof(T).FullName, true);
            ICreatable<T> createableInstance = Activator.CreateInstance(type) as ICreatable<T>;
            return createableInstance;
        }

        //private IEnumerable<RecordLine> GetRecords()
        //{
        //    using (FileStream fs = File.Open(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        //    using (StreamReader sr = new StreamReader(bs, Encoding.GetEncoding("iso-8859-1")))
        //    {
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            var line = new RecordLine();
        //            // use logic to create a RecordLine object here
        //            yield return line;
        //        }
        //    }
        //}

        //public void InsertBulkLog()
        //{
        //    try
        //    {
        //        var connectionString = ConfigurationManager.AppSettings["DBConString"];
        //        using (var reader = ObjectReader.Create(GetRecords());
        //        using (var bulkCopy = new SqlBulkCopy(connectionString))
        //        {
        //            bulkCopy.BulkCopyTimeout = 600;
        //            bulkCopy.DestinationTableName = table.TableName;
        //            bulkCopy.WriteToServer(reader);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Write to log
        //    }
        //}
        #endregion

    }
}
