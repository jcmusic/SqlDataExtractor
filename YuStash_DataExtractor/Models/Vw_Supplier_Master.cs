using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    public class Vw_Supplier_Master : ICreatable<Vw_Supplier_Master>
    {
        #region Props
        char commaReplacementChar = '|';

        string _transactionId;
        string _supplier_Legal_Entity;
        string _supplierName_Alias;
        string _cSRFlag;
        string _addrType;
        string _addr1;
        string _addr2;
        string _addr3;
        string _city;
        string _state;
        string _postCode;
        string _countryCode;
        string _contactName;
        string _eMail;
        string _phone;
        string _supplierPortalFlag;
        string _pO_EMailer;
        string _gEO;
        string _procurementModel;
        string _pricingTableFlag;
        string _paymentTerms;
        string _pO_Prefix;
        string _incoterms;
        string _productCategory;
        string _productType;
        string _tierLevel;
        string _dualSupplierFlag;
        string _shipToWarehouse;
        string _custEntityOmni;

        public string TransactionId { get; set; }
        public string Supplier_Legal_Entity { get { return _supplier_Legal_Entity.Replace(',', commaReplacementChar); } set { _supplier_Legal_Entity = value; } }
        public string SupplierName_Alias { get { return _supplierName_Alias.Replace(',', commaReplacementChar); } set { _supplierName_Alias = value; } }
        public string CSRFlag { get { return _cSRFlag.Replace(',', commaReplacementChar); } set { _cSRFlag = value; } }
        public string AddrType { get { return _addrType.Replace(',', commaReplacementChar); } set { _addrType = value; } }
        public string Addr1 { get { return _addr1.Replace(',', commaReplacementChar); } set { _addr1 = value; } }
        public string Addr2 { get { return _addr2.Replace(',', commaReplacementChar); } set { _addr2 = value; } }
        public string Addr3 { get { return _addr3.Replace(',', commaReplacementChar); } set { _addr3 = value; } }
        public string City { get { return _city.Replace(',', commaReplacementChar); } set { _city = value; } }
        public string State { get { return _state.Replace(',', commaReplacementChar); } set { _state = value; } }
        public string PostCode { get { return _postCode.Replace(',', commaReplacementChar); } set { _postCode = value; } }
        public string CountryCode { get { return _countryCode.Replace(',', commaReplacementChar); } set { _countryCode = value; } }
        public string ContactName { get { return _contactName.Replace(',', commaReplacementChar); } set { _contactName = value; } }
        public string EMail { get { return _eMail.Replace(',', commaReplacementChar); } set { _eMail = value; } }
        public string Phone { get { return _phone.Replace(',', commaReplacementChar); } set { _phone = value; } }
        public string SupplierPortalFlag { get { return _supplierPortalFlag.Replace(',', commaReplacementChar); } set { _supplierPortalFlag = value; } }
        public string PO_EMailer { get { return _pO_EMailer.Replace(',', commaReplacementChar); } set { _pO_EMailer = value; } }
        public string GEO { get { return _gEO.Replace(',', commaReplacementChar); } set { _gEO = value; } }
        public string ProcurementModel { get { return _procurementModel.Replace(',', commaReplacementChar); } set { _procurementModel = value; } }
        public string PricingTableFlag { get { return _pricingTableFlag.Replace(',', commaReplacementChar); } set { _pricingTableFlag = value; } }
        public string PaymentTerms { get { return _paymentTerms.Replace(',', commaReplacementChar); } set { _paymentTerms = value; } }
        public string PO_Prefix { get { return _pO_Prefix.Replace(',', commaReplacementChar); } set { _pO_Prefix = value; } }
        public string Incoterms { get { return _incoterms.Replace(',', commaReplacementChar); } set { _incoterms = value; } }
        public string ProductCategory { get { return _productCategory.Replace(',', commaReplacementChar); } set { _productCategory = value; } }
        public string ProductType { get { return _productType.Replace(',', commaReplacementChar); } set { _productType = value; } }
        public string TierLevel { get { return _tierLevel.Replace(',', commaReplacementChar); } set { _tierLevel = value; } }
        public string DualSupplierFlag { get { return _dualSupplierFlag.Replace(',', commaReplacementChar); } set { _dualSupplierFlag = value; } }
        public string ShipToWarehouse { get { return _shipToWarehouse.Replace(',', commaReplacementChar); } set { _shipToWarehouse = value; } }
        public string CustEntityOmni { get { return _custEntityOmni.Replace(',', commaReplacementChar); } set { _custEntityOmni = value; } }
        #endregion

        public Vw_Supplier_Master Create(IDataRecord record, Guid transactionId)
        {
            return new Vw_Supplier_Master
            {
                TransactionId = transactionId.ToString(),
                Supplier_Legal_Entity = record[0].ToString(),
                SupplierName_Alias = record[1].ToString(),
                CSRFlag = record[2].ToString(),
                AddrType = record[3].ToString(),
                Addr1 = record[4].ToString(),
                Addr2 = record[5].ToString(),
                Addr3 = record[6].ToString(),
                City = record[7].ToString(),
                State = record[8].ToString(),
                PostCode = record[9].ToString(),
                CountryCode = record[10].ToString(),
                ContactName = record[11].ToString(),
                EMail = record[12].ToString(),
                Phone = record[13].ToString(),
                SupplierPortalFlag = record[14].ToString(),
                PO_EMailer = record[15].ToString(),
                GEO = record[16].ToString(),
                ProcurementModel = record[17].ToString(),
                PricingTableFlag = record[18].ToString(),
                PaymentTerms = record[19].ToString(),
                PO_Prefix = record[20].ToString(),
                Incoterms = record[21].ToString(),
                ProductCategory = record[22].ToString(),
                ProductType = record[23].ToString(),
                TierLevel = record[24].ToString(),
                DualSupplierFlag = record[25].ToString(),
                ShipToWarehouse = record[26].ToString(),
                CustEntityOmni = record[27].ToString(),
            };
        }
    }
}
