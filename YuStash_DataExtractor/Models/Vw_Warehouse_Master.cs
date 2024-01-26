using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    public class Vw_Warehouse_Master : ICreatable<Vw_Warehouse_Master>
    {
        #region Props
        char commaReplacementChar = '|';

        string _transactionId;
        string _whseEntityName;
        string _whseAlias;
        string _addr1;
        string _addr2;
        string _addr3;
        string _city;
        string _stateCode;
        string _postCode;
        string _countryCode;
        string _contact;
        string _eMail;
        string _phoneNo;
        string _gEO;
        string _services;
        string _whseType;
        string _salesChannel;
        string _shipToCustomer;
        string _regionSupported;
        string _productType;
        string _productChannel;
        string _primaryCategory;
        string _pPS_LT;
        string _shipping_LT_To_Customer;
        string _eDI_API;
        string _custRecordOmni;



        public string TransactionId { get; set; }
        public string WhseEntityName { get { return _whseEntityName.Replace(',', commaReplacementChar); } set { _whseEntityName = value; } }
        public string WhseAlias { get { return _whseAlias.Replace(',', commaReplacementChar); } set { _whseAlias = value; } }
        public string Addr1 { get { return _addr1.Replace(',', commaReplacementChar); } set { _addr1 = value; } }
        public string Addr2 { get { return _addr2.Replace(',', commaReplacementChar); } set { _addr2 = value; } }
        public string Addr3 { get { return _addr3.Replace(',', commaReplacementChar); } set { _addr3 = value; } }
        public string City { get { return _city.Replace(',', commaReplacementChar); } set { _city = value; } }
        public string StateCode { get { return _stateCode.Replace(',', commaReplacementChar); } set { _stateCode = value; } }
        public string PostCode { get { return _postCode.Replace(',', commaReplacementChar); } set { _postCode = value; } }
        public string CountryCode { get { return _countryCode.Replace(',', commaReplacementChar); } set { _countryCode = value; } }
        public string Contact { get { return _contact.Replace(',', commaReplacementChar); } set { _contact = value; } }
        public string EMail { get { return _eMail.Replace(',', commaReplacementChar); } set { _eMail = value; } }
        public string PhoneNo { get { return _phoneNo.Replace(',', commaReplacementChar); } set { _phoneNo = value; } }
        public string GEO { get { return _gEO.Replace(',', commaReplacementChar); } set { _gEO = value; } }
        public string Services { get { return _services.Replace(',', commaReplacementChar); } set { _services = value; } }
        public string WhseType { get { return _whseType.Replace(',', commaReplacementChar); } set { _whseType = value; } }
        public string SalesChannel { get { return _salesChannel.Replace(',', commaReplacementChar); } set { _salesChannel = value; } }
        public string ShipToCustomer { get { return _shipToCustomer.Replace(',', commaReplacementChar); } set { _shipToCustomer = value; } }
        public string RegionSupported { get { return _regionSupported.Replace(',', commaReplacementChar); } set { _regionSupported = value; } }
        public string ProductType { get { return _productType.Replace(',', commaReplacementChar); } set { _productType = value; } }
        public string ProductChannel { get { return _productChannel.Replace(',', commaReplacementChar); } set { _productChannel = value; } }
        public string PrimaryCategory { get { return _primaryCategory.Replace(',', commaReplacementChar); } set { _primaryCategory = value; } }
        public string PPS_LT { get { return _pPS_LT.Replace(',', commaReplacementChar); } set { _pPS_LT = value; } }
        public string Shipping_LT_To_Customer { get { return _shipping_LT_To_Customer.Replace(',', commaReplacementChar); } set { _shipping_LT_To_Customer = value; } }
        public string EDI_API { get { return _eDI_API.Replace(',', commaReplacementChar); } set { _eDI_API = value; } }
        public string CustRecordOmni { get { return _custRecordOmni.Replace(',', commaReplacementChar); } set { _custRecordOmni = value; } }

        #endregion

        public Vw_Warehouse_Master Create(IDataRecord record, Guid transactionId)
        {
            return new Vw_Warehouse_Master
            {
                TransactionId = transactionId.ToString(),
                WhseEntityName = record[0].ToString(),
                WhseAlias = record[1].ToString(),
                Addr1 = record[2].ToString(),
                Addr2 = record[3].ToString(),
                Addr3 = record[4].ToString(),
                City = record[5].ToString(),
                StateCode = record[6].ToString(),
                PostCode = record[7].ToString(),
                CountryCode = record[8].ToString(),
                Contact = record[9].ToString(),
                EMail = record[10].ToString(),
                PhoneNo = record[11].ToString(),
                GEO = record[12].ToString(),
                Services = record[13].ToString(),
                WhseType = record[14].ToString(),
                SalesChannel = record[15].ToString(),
                ShipToCustomer = record[16].ToString(),
                RegionSupported = record[17].ToString(),
                ProductType = record[18].ToString(),
                ProductChannel = record[19].ToString(),
                PrimaryCategory = record[20].ToString(),
                PPS_LT = record[21].ToString(),
                Shipping_LT_To_Customer = record[22].ToString(),
                EDI_API = record[23].ToString(),
                CustRecordOmni = record[24].ToString()
            };
        }
    }
}
