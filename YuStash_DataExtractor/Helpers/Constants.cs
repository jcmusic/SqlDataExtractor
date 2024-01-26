namespace YuStashSageX3_ETL.Helpers
{
    internal static class Constants
    {
        internal const string ZOMNI_BOM_MASTER_HEADERS = "BA Part No.,Version,Valid From,Valid To,Lifecycle,Status,Component Level,Sequence,RM Part No.,Description,Usage,Unit Cost,Is Pkg Item,MVA $,Is MVA,Special Services $,Is Special Service,Is Alternate Item,Rule,Min,Max,Ranking,custrecord_omni";
        internal const string ZOMNI_CUSTOMER_MASTER_HEADERS = "Customer Name,Account Name,No. Stores,CSR Flag,Bill To Name,Bill To Add 1,Bill To Add 2,Bill To Add 3,Bill To City,Bill To State,Bill To Post Code,Bill To Country,Bill To Contact Name,Bill To eMail,Bill To Phone No.,Ship To Name,Ship To Add 1,Ship To Add 2,Ship To Add 3,Ship To City,Ship To State,Ship To Post Code,Ship To Country,Ship To Contact Name,Ship To eMail,Ship To Phone No.,Customer Type,GEO,Procurement Model,Payment Terms,Incoterms,Product Category,Product Type,Tier Level,BBD Flag,custentity_omni";
        internal const string ZOMNI_ITEM_MASTER_HEADERS = "Part No.,Product Description,Customs Product Description,Channel,UPC Code,EAN,JAN,GTIN,SCC-14,Primary Category,Secondary Category,Tertiary Category,Season,Dept,Class,Size,Color,Product Type,Make to Order Flag,Lifecycle Flag,Start Date,End Date,Lot ID Flag,Batch ID Flag,Serial No. Flag,HS Code,Buy Cost $,Sell Price $,Multi-Currency Flag,Price (€),Price (£),Supplier Pricing Flag,Customer Pricing Flag,is Dual Sourced,Supplier,Multi-Supplier Allocation Split %,Supplier PN,Disti PN,Customer PN,Customer,COO,Warehouse,Multi-Warehouse Allocation Split %,Is Temp Controlled?,Is Secure Stored?,UOM,Unit Length (in),Unit Width (in),Unit Height (in),Unit Weight (lbs),Master Carton Qty,Master Carton Length (in),Master Carton Width (in),Master Carton Height (in),Master Carton Weight (lbs),Pallet Qty,Pallet Length (in),Pallet Width (in),Pallet Height (in),Pallet Weight (lbs),Master Carton Qty per Pallet,Master Carton Qty per Pallet Layer,No. of Layers per Pallet,No. of Pallets per FTL,FTL Truck Type,No. Pallets per Container,No. Master Cases per Contianer,No. Units per Container,Inner Case Qty,Inner Case Length (in),Inner Case Width (in),Inner Case Height (in),Inner Case Weight (lbs),custitem_omni";
        internal const string ZOMNI_SALES_ORDERS_HEADERS = "Order Date-Time,Customer,Order No.,Channel,Address 1,Address 2,City,State,Country,Carrier,Ship by Date,Receive by Date,Status,Item,Qty,$ Value,Discount,Reference No.,Customer Ref.,Ship From Location";
        internal const string ZOMNI_SHIPPING_CONFIRMATION_HEADERS = "Order Date-Time,Customer,Order No.,Channel,State,Country,Carrier,Status,Item,Qty,$ Value,Discount,Lot ID,Expiry Date,Reference No.,Customer Ref.,Date Shpd,Shpd From,Tracking No.";
        internal const string ZOMNI_SUPPLIER_CONSTRAINTS_HEADERS = "Supplier,Product Type,Primary Category,Part No,Description,MOQ,CPC Rule - Level,Cum. Production Capacity Max (Weekly),EOQ,Lead-Time for 1st order (calendar days),Lead-Time for Reorder (calendar days),Shipping Lead Time (Cal. Days),DSI Target (calendar days),DSI Min,DSI Max";
        internal const string ZOMNI_SUPPLIER_MASTER_HEADERS = "Supplier (Legal Entity),Supplier Name (Alias),CSR Flag,Add Type,Add 1,Add 2,Add 3,City,State,Post Code,Country Code,Contact Name,eMail,Phone,Supplier Portal Flag,PO eMailer,GEO,Procurement Model,Pricing Table Flag,Payment Terms,PO Prefix,Incoterms,Product Category,Product Type,Tier Level,Dual Supplier Flag,Ship to Warehouse,custentity_omni";
        internal const string ZOMNI_WAREHOUSE_MASTER_HEADERS = "Whse Entity Name,Whse Alias,Add 1,Add 2,Add 3,City,State Code,Post Code,Country Code,Contact,eMail,Phone No.,GEO,Services,Whse Type,Sales Channel,Ship To Customer,Region Supported,Product Type,Product Channel,Primary Category,PPS LT,Shipping LT to Customer,EDI / API,custrecord_omni";
    

        //YuStash Source Db
        internal const string YUSTASH_SOURCE_DB_CXN_STRING = "Server=192.168.4.198;Database=x3;uid=development@omnichains.com;Password=SD\"|OlFITmYOFr*oxLYB;Connection Timeout=0;";

        //Omni Db SP
        internal const string OMNI_DB_SP_NAME = "[etl].[sp_Sync_YuStash]";



        //  *********************  For testing UAT as the bridge to the YuStash db ***********************//
        ////UAT Db
        //internal const string OMNI_DB_CXN_STRING = "Server=omnichainv2nonprod.database.windows.net;Initial Catalog=Omnichain-V2-UAT2-ApplicationDB;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;";

        ////Dev BlobStorage
        //internal const string CdnAddress = "https://omnidocsdev.blob.core.windows.net";
        //internal const string CdnClientFileUploadContainer = "client-uploads";
        //internal const string CdnConnectionString = "DefaultEndpointsProtocol=https;AccountName=omnidocsdev;AccountKey=rJAotIwGcuq58V5NXcew7FFhtewJI4H/nAVJc4OefvUt3i++4FWsGfyPDfCUxOD+xRO6X8NnOmnxnOEACvIqpA==;EndpointSuffix=core.windows.net";

        ////UAT MsgQueue
        //internal const string MSG_QUEUE_NAME = "long-running-stored-procedures-uat";
        //internal const string MSG_QUEUE_CXN_STRING = "DefaultEndpointsProtocol=https;AccountName=omnimessagequeuedev;AccountKey=hNNg60P/2xMRgYrYTwIQJVrpgCVME+FNVts4LERxLq9wp+j89Dy1+G4JkFL2DzqinxeDRoqTOgMH7rZkUhV5fg==;EndpointSuffix=core.windows.net;";



        //  *********************  For Prod as the bridge to the YuStash db ***********************//
        //Prod Db
        internal const string OMNI_DB_CXN_STRING = "Server=omnichain.database.windows.net;Database=Omnichain-V2-Prod-ApplicationDB;uid=OmnichainDatabaseAdmin;Password=T2839s18s!;MultipleActiveResultSets=False;Connection Timeout=300;";

        //Prod BlobStorage
        internal const string CdnAddress = "https://omnidocsprod.blob.core.windows.net/";
        internal const string CdnClientFileUploadContainer = "client-uploads";
        internal const string CdnConnectionString = "DefaultEndpointsProtocol=https;AccountName=omnidocsprod;AccountKey=6r0IRWyNYS/n2mHC2KiAPMNFf+ucuQrut9rPy6VK47kUXmbWOjI2+uPtIQCON6eWxYlLS1tLBF/tnR2cp/+uUQ==;EndpointSuffix=core.windows.net";


        //Prod MsgQueue
        internal const string MSG_QUEUE_NAME = "long-running-stored-procedures-prod";
        internal const string MSG_QUEUE_CXN_STRING = "DefaultEndpointsProtocol=https;AccountName=omnimessagequeueprod;AccountKey=iCE/FZBufwz8FvYOt3y6vrPbnyKSdsacZOMVPax/VZyvhQBCF4K70CRnYNXiYPG4nIqPiuCmf8ia3jdm4n/suQ==;EndpointSuffix=core.windows.net;";
    }
}
