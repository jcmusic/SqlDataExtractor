using CsvHelper.Configuration.Attributes;
using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    [Delimiter("|")]
    public class Vw_Customer_Master : ICreatable<Vw_Customer_Master>
    {
        #region Props
        char commaReplacementChar = '|';

        string _customerName;
        string _accountName;
        string _nStores;
        string _cSRFlag;
        string _billToName;
        string _billToAddr1;
        string _billToAddr2;
        string _billToAddr3;
        string _billToCity;
        string _billToState;
        string _billToPostCode;
        string _billToCountry;
        string _billToContactName;
        string _billToEmail;
        string _billToPhoneNo;
        string _shipToName;
        string _shipToAddr1;
        string _shipToAddr2;
        string _shipToAddr3;
        string _shipToCity;
        string _shipToState;
        string _shipToPostCode;
        string _shipToCountry;
        string _shipToContactName;
        string _shipToEmail;
        string _shipToPhoneNo;
        string _customerType;
        string _gEO;
        string _procurementModel;
        string _paymentTerms;
        string _incoterms;
        string _productCategory;
        string _productType;
        string _tierLevel;
        string _bBDFlag;
        string _custEntity_Omni;

        public string TransactionId { get; set; }
        public string CustomerName { get { return _customerName.Replace(',', commaReplacementChar); } set { _customerName = value; } }
        public string AccountName { get { return _accountName.Replace(',', commaReplacementChar); } set { _accountName = value; } }
        public string NoStores { get { return _nStores.Replace(',', commaReplacementChar); } set { _nStores = value; } }
        public string CSRFlag { get { return _cSRFlag.Replace(',', commaReplacementChar); } set { _cSRFlag = value; } }
        public string BillToName { get { return _billToName.Replace(',', commaReplacementChar); } set { _billToName = value; } }
        public string BillToAddr1 { get { return _billToAddr1.Replace(',', commaReplacementChar); } set { _billToAddr1 = value; } }
        public string BillToAddr2 { get { return _billToAddr2.Replace(',', commaReplacementChar); } set { _billToAddr2 = value; } }
        public string BillToAddr3 { get { return _billToAddr3.Replace(',', commaReplacementChar); } set { _billToAddr3 = value; } }
        public string BillToCity { get { return _billToCity.Replace(',', commaReplacementChar); } set { _billToCity = value; } }
        public string BillToState { get { return _billToState.Replace(',', commaReplacementChar); } set { _billToState = value; } }
        public string BillToPostCode { get { return _billToPostCode.Replace(',', commaReplacementChar); } set { _billToPostCode = value; } }
        public string BillToCountry { get { return _billToCountry.Replace(',', commaReplacementChar); } set { _billToCountry = value; } }
        public string BillToContactName { get { return _billToContactName.Replace(',', commaReplacementChar); } set { _billToContactName = value; } }
        public string BillToEmail { get { return _billToEmail.Replace(',', commaReplacementChar); } set { _billToEmail = value; } }
        public string BillToPhoneNo { get { return _billToPhoneNo.Replace(',', commaReplacementChar); } set { _billToPhoneNo = value; } }
        public string ShipToName { get { return _shipToName.Replace(',', commaReplacementChar); } set { _shipToName = value; } }
        public string ShipToAddr1 { get { return _shipToAddr1.Replace(',', commaReplacementChar); } set { _shipToAddr1 = value; } }
        public string ShipToAddr2 { get { return _shipToAddr2.Replace(',', commaReplacementChar); } set { _shipToAddr2 = value; } }
        public string ShipToAddr3 { get { return _shipToAddr3.Replace(',', commaReplacementChar); } set { _shipToAddr3 = value; } }
        public string ShipToCity { get { return _shipToCity.Replace(',', commaReplacementChar); } set { _shipToCity = value; } }
        public string ShipToState { get { return _shipToState.Replace(',', commaReplacementChar); } set { _shipToState = value; } }
        public string ShipToPostCode { get { return _shipToPostCode.Replace(',', commaReplacementChar); } set { _shipToPostCode = value; } }
        public string ShipToCountry { get { return _shipToCountry.Replace(',', commaReplacementChar); } set { _shipToCountry = value; } }
        public string ShipToContactName { get { return _shipToContactName.Replace(',', commaReplacementChar); } set { _shipToContactName = value; } }
        public string ShipToEmail { get { return _shipToEmail.Replace(',', commaReplacementChar); } set { _shipToEmail = value; } }
        public string ShipToPhoneNo { get { return _shipToPhoneNo.Replace(',', commaReplacementChar); } set { _shipToPhoneNo = value; } }
        public string CustomerType { get { return _customerType.Replace(',', commaReplacementChar); } set { _customerType = value; } }
        public string GEO { get { return _gEO.Replace(',', commaReplacementChar); } set { _gEO = value; } }
        public string ProcurementModel { get { return _procurementModel.Replace(',', commaReplacementChar); } set { _procurementModel = value; } }
        public string PaymentTerms { get { return _paymentTerms.Replace(',', commaReplacementChar); } set { _paymentTerms = value; } }
        public string Incoterms { get { return _incoterms.Replace(',', commaReplacementChar); } set { _incoterms = value; } }
        public string ProductCategory { get { return _productCategory.Replace(',', '|'); } set { _productCategory = value; } }
        public string ProductType { get { return _productType.Replace(',', '|'); } set { _productType = value; } }
        public string TierLevel { get { return _tierLevel.Replace(',', commaReplacementChar); } set { _tierLevel = value; } }
        public string BBDFlag { get { return _bBDFlag.Replace(',', commaReplacementChar); } set { _bBDFlag = value; } }
        public string CustEntity_Omni { get { return _custEntity_Omni.Replace(',', commaReplacementChar); } set { _custEntity_Omni = value; } }

        #endregion

        public Vw_Customer_Master Create(IDataRecord record, Guid transactionId)
        {
            return new Vw_Customer_Master
            {
                TransactionId = transactionId.ToString(),
                CustomerName = record[0].ToString(),
                AccountName = record[1].ToString(),
                NoStores = record[2].ToString(),
                CSRFlag = record[3].ToString(),
                BillToName = record[4].ToString(),
                BillToAddr1 = record[5].ToString(),
                BillToAddr2 = record[6].ToString(),
                BillToAddr3 = record[7].ToString(),
                BillToCity = record[8].ToString(),
                BillToState = record[9].ToString(),
                BillToPostCode = record[10].ToString(),
                BillToCountry = record[11].ToString(),
                BillToContactName = record[12].ToString(),
                BillToEmail = record[13].ToString(),
                BillToPhoneNo = record[14].ToString(),
                ShipToName = record[15].ToString(),
                ShipToAddr1 = record[16].ToString(),
                ShipToAddr2 = record[17].ToString(),
                ShipToAddr3 = record[18].ToString(),
                ShipToCity = record[19].ToString(),
                ShipToState = record[20].ToString(),
                ShipToPostCode = record[21].ToString(),
                ShipToCountry = record[22].ToString(),
                ShipToContactName = record[23].ToString(),
                ShipToEmail = record[24].ToString(),
                ShipToPhoneNo = record[25].ToString(),
                CustomerType = record[26].ToString(),
                GEO = record[27].ToString(),
                ProcurementModel = record[28].ToString(),
                PaymentTerms = record[29].ToString(),
                Incoterms = record[30].ToString(),
                ProductCategory = record[31].ToString(),
                ProductType = record[32].ToString(),
                TierLevel = record[33].ToString(),
                BBDFlag = record[34].ToString(),
                CustEntity_Omni = record[35].ToString()
            };
        }
    }
}
