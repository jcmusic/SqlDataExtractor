using Azure.Storage.Queues;
using YuStashSageX3_ETL.Helpers;
using System;
using System.Threading.Tasks;

namespace YuStashSageX3_ETL
{
    public interface IMessageQueueService
    {
        Task ExecuteStoredProcedureAsync(string sqlExecStringParams, string procedureName, Guid transactionId);
        //Task AddEventTransactionRecord(User user, TransactionType transactionType, string inventoryAuditEvent, Guid transactionId, bool saveChanges, string message = null);
    }

    public class MessageQueueService : IMessageQueueService
    {
        #region Properties/Ctor 

        public MessageQueueService()
        { }

        #endregion

        #region Public methods

        public async Task ExecuteStoredProcedureAsync(string sqlExecStringParams, string procedureName, Guid transactionId)
        {
            await ExecuteViaMessageQueue(sqlExecStringParams, procedureName, transactionId);
        }

        //public async Task AddEventTransactionRecord(User user, TransactionType transactionType, string inventoryAuditEvent, Guid transactionId, bool saveChanges, string message = null)
        //{
        //    await Db.Transactions.AddAsync(new Transaction
        //    {
        //        TransactionType = transactionType,
        //        TransactionId = transactionId,
        //        UserId = user.Id,
        //        ClientId = user.ClientId,
        //        EventDetail = inventoryAuditEvent,
        //        Message = message
        //    });

        //    if (saveChanges) await Db.SaveChangesAsync();
        //}

        #endregion

        #region Private methods

        private async Task ExecuteViaMessageQueue(string storedProcedureParams, string sqlStoredProcedureName, Guid transactionId, bool useEnvironmentVariable = false)
        {
            string msgPartDelimeter = ":";
            string message = ConstructMessage(sqlStoredProcedureName, storedProcedureParams, transactionId, msgPartDelimeter);

            //_logger.LogInformation($"sending transactionId {transactionId} to the queue for: {sqlStoredProcedureName} {storedProcedureParams}");

            //await SetSqlSpStatus(sqlStoredProcedureName, MsgQueueStatusType.MarkedForExecution, transactionId, message);

            await AddMessageToQueue(message, useEnvironmentVariable);

            //await SetSqlSpStatus(sqlStoredProcedureName, MsgQueueStatusType.Producer_MessageQueued, transactionId, message);

            //_logger.LogInformation($"transactionId {transactionId} added to the queue");
        }

        private static string ConstructMessage(string storedProcedureName, string storedProcedureParams, Guid transactionId, string msgPartDelimeter)
        {
            return $"transactionId={transactionId}{msgPartDelimeter}{storedProcedureName}{msgPartDelimeter}{storedProcedureParams}";
        }

        private async Task AddMessageToQueue(string message, bool useEnvironmentVariable = false)
        {
            //message = ConversionHelper.EncodeBase64(message);
            await InsertMessageAsync(message, useEnvironmentVariable);
        }

        private async Task InsertMessageAsync(string newMessage, bool useEnvironmentVariable = false)
        {
            string messageQueueConnString = Constants.MSG_QUEUE_CXN_STRING;
            string messageQueueName = Constants.MSG_QUEUE_NAME;

            if (useEnvironmentVariable)
            {
                messageQueueConnString = Constants.MSG_QUEUE_CXN_STRING;
                messageQueueName = Constants.MSG_QUEUE_NAME;
            }

            QueueClient queue = new QueueClient(messageQueueConnString, messageQueueName);

            try
            {
                if (null != await queue.CreateIfNotExistsAsync())
                {
                    Console.WriteLine("The queue was created");
                }

                await queue.SendMessageAsync(newMessage);  // Time-to-live default is 7 days
            }
            catch (Exception e)
            {
                //_logger.LogError(e.Message);
                throw;
            }

            //await theQueue.SendMessageAsync(newMessage, default, TimeSpan.FromSeconds(-1), default);   // This one never expires
        }

        //private async Task SetSqlSpStatus(string SQL_SP_NAME, MsgQueueStatusType msgQueueStatus, Guid transactionId, string message)
        //{
        //    message = message.Replace("'", "");

        //    await Db.TransactionStatuses.AddAsync(new TransactionStatus
        //    {
        //        SourceName = SQL_SP_NAME,
        //        Status = msgQueueStatus,
        //        TransactionId = transactionId,
        //        Message = message
        //    });

        //    try
        //    {
        //        await Db.SaveChangesAsync();
        //        _logger.LogInformation($"TransactionId: {transactionId}, ProcedureName: {SQL_SP_NAME}, ProcedureStatus: {msgQueueStatus}, Message {message}");
        //    }
        //    catch (Exception)
        //    {
        //        _logger.LogError($"SaveChanges failed for Db.TransactionStatus: {transactionId}, ProcedureName: {SQL_SP_NAME}, ProcedureStatus: {msgQueueStatus}, Message {message}");
        //    }
        //}


        #endregion
    }
}
