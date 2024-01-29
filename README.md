# SqlDataExtractor

ETL solution for pulling data from target Sql Server view:

1. Connects to target SQL Server
2. Interates thru views (for each):
3. pulling data
4. converts to csv
5. Upload to Azure Blob storage
6. Send msg to queue for further Bulk Import processing
   
###VS 2019 C#
