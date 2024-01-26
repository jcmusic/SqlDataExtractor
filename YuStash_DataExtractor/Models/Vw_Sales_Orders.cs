using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    public class Vw_Sales_Orders : ICreatable<Vw_Sales_Orders>
    {
        #region Props
        char commaReplacementChar = '|';

        string _TransactionId;
        string _orderDateTime;
        string _customer;
        string _orderNo;
        string _channel;
        string _address1;
        string _address2;
        string _city;
        string _state;
        string _country;
        string _carrier;
        string _shipByDate;
        string _receiveByDate;
        string _status;
        string _item;
        string _qty;
        string _value;
        string _discount;
        string _referenceNo;
        string _customerRef;
        string _shipFromLocation;


        public string TransactionId { get; set; }
        public string OrderDateTime { get { return _orderDateTime.Replace(',', commaReplacementChar); } set { _orderDateTime = value; } }
        public string Customer { get { return _customer.Replace(',', commaReplacementChar); } set { _customer = value; } }
        public string OrderNo { get { return _orderNo.Replace(',', commaReplacementChar); } set { _orderNo = value; } }
        public string Channel { get { return _channel.Replace(',', commaReplacementChar); } set { _channel = value; } }
        public string Address1 { get { return _address1.Replace(',', commaReplacementChar); } set { _address1 = value; } }
        public string Address2 { get { return _address2.Replace(',', commaReplacementChar); } set { _address2 = value; } }
        public string City { get { return _city.Replace(',', commaReplacementChar); } set { _city = value; } }
        public string State { get { return _state.Replace(',', commaReplacementChar); } set { _state = value; } }
        public string Country { get { return _country.Replace(',', commaReplacementChar); } set { _country = value; } }
        public string Carrier { get { return _carrier.Replace(',', commaReplacementChar); } set { _carrier = value; } }
        public string ShipByDate { get { return _shipByDate.Replace(',', commaReplacementChar); } set { _shipByDate = value; } }
        public string ReceiveByDate { get { return _receiveByDate.Replace(',', commaReplacementChar); } set { _receiveByDate = value; } }
        public string Status { get { return _status.Replace(',', commaReplacementChar); } set { _status = value; } }
        public string Item { get { return _item.Replace(',', commaReplacementChar); } set { _item = value; } }
        public string Qty { get { return _qty.Replace(',', commaReplacementChar); } set { _qty = value; } }
        public string Value { get { return _value.Replace(',', commaReplacementChar); } set { _value = value; } }
        public string Discount { get { return _discount.Replace(',', commaReplacementChar); } set { _discount = value; } }
        public string ReferenceNo { get { return _referenceNo.Replace(',', commaReplacementChar); } set { _referenceNo = value; } }
        public string CustomerRef { get { return _customerRef.Replace(',', commaReplacementChar); } set { _customerRef = value; } }
        public string ShipFromLocation { get { return _shipFromLocation.Replace(',', commaReplacementChar); } set { _shipFromLocation = value; } }

        //public string A0 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A1 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A2 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A3 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A4 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A5 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A6 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A7 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A8 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A9 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }


        //public string A0 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A1 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A2 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A3 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A4 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A5 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A6 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A7 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A8 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        //public string A9 { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        #endregion

        public Vw_Sales_Orders Create(IDataRecord record, Guid transactionId)
        {
            return new Vw_Sales_Orders
            {
                TransactionId = transactionId.ToString(),
                OrderDateTime = record[0].ToString(),
                Customer = record[1].ToString(),
                OrderNo = record[2].ToString(),
                Channel = record[3].ToString(),
                Address1 = record[4].ToString(),
                Address2 = record[5].ToString(),
                City = record[6].ToString(),
                State = record[7].ToString(),
                Country = record[8].ToString(),
                Carrier = record[9].ToString(),
                ShipByDate = record[10].ToString(),
                ReceiveByDate = record[11].ToString(),
                Status = record[12].ToString(),
                Item = record[13].ToString(),
                Qty = record[14].ToString(),
                Value = record[15].ToString(),
                Discount = record[16].ToString(),
                ReferenceNo = record[17].ToString(),
                CustomerRef = record[18].ToString(),
                ShipFromLocation = record[19].ToString()


                //A0 = record[10].ToString(),
                //A1 = record[11].ToString(),
                //A2 = record[12].ToString(),
                //A3 = record[13].ToString(),
                //A4 = record[14].ToString(),
                //A5 = record[15].ToString(),
                //A6 = record[16].ToString(),
                //A7 = record[17].ToString(),
                //A8 = record[18].ToString(),
                //A9 = record[19].ToString(),

            };
        }
    }
}
