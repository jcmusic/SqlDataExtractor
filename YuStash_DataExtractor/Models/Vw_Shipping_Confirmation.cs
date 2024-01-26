using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    public class Vw_Shipping_Confirmation : ICreatable<Vw_Shipping_Confirmation>
    {
        #region Props
        char commaReplacementChar = '|';

        string _TransactionId;
        string _orderDateTime;
        string _customer;
        string _orderNo;
        string _channel;
        string _state;
        string _country;
        string _carrier;
        string _status;
        string _item;
        string _qty;
        string _value;
        string _discount;
        string _lotId;
        string _expiryDate;
        string _referenceNo;
        string _customerRef;
        string _dateShpd;
        string _shpdFrom;
        string _trackingNo;



        public string TransactionId { get; set; }
        public string OrderDateTime  { get { return _orderDateTime.Replace(',', commaReplacementChar); } set { _orderDateTime = value; } }
        public string Customer  { get { return _customer.Replace(',', commaReplacementChar); } set { _customer = value; } }
        public string OrderNo  { get { return _orderNo.Replace(',', commaReplacementChar); } set { _orderNo = value; } }
        public string Channel  { get { return _channel.Replace(',', commaReplacementChar); } set { _channel = value; } }
        public string State  { get { return _state.Replace(',', commaReplacementChar); } set { _state = value; } }
        public string Country  { get { return _country.Replace(',', commaReplacementChar); } set { _country = value; } }
        public string Carrier  { get { return _carrier.Replace(',', commaReplacementChar); } set { _carrier = value; } }
        public string Status  { get { return _status.Replace(',', commaReplacementChar); } set { _status = value; } }
        public string Item  { get { return _item.Replace(',', commaReplacementChar); } set { _item = value; } }
        public string Qty  { get { return _qty.Replace(',', commaReplacementChar); } set { _qty = value; } }
        public string Value  { get { return _value.Replace(',', commaReplacementChar); } set { _value = value; } }
        public string Discount  { get { return _discount.Replace(',', commaReplacementChar); } set { _discount = value; } }
        public string LotId  { get { return _lotId.Replace(',', commaReplacementChar); } set { _lotId = value; } }
        public string ExpiryDate  { get { return _expiryDate.Replace(',', commaReplacementChar); } set { _expiryDate = value; } }
        public string ReferenceNo  { get { return _referenceNo.Replace(',', commaReplacementChar); } set { _referenceNo = value; } }
        public string CustomerRef  { get { return _customerRef.Replace(',', commaReplacementChar); } set { _customerRef = value; } }
        public string DateShpd  { get { return _dateShpd.Replace(',', commaReplacementChar); } set { _dateShpd = value; } }
        public string ShpdFrom  { get { return _shpdFrom.Replace(',', commaReplacementChar); } set { _shpdFrom = value; } }
        public string TrackingNo  { get { return _trackingNo.Replace(',', commaReplacementChar); } set { _trackingNo = value; } }

        #endregion

        public Vw_Shipping_Confirmation Create(IDataRecord record, Guid transactionId)
        {
            return new Vw_Shipping_Confirmation
            {
                TransactionId = transactionId.ToString(),
                OrderDateTime = record[0].ToString(),
                Customer = record[1].ToString(),
                OrderNo = record[2].ToString(),
                Channel = record[3].ToString(),
                State = record[4].ToString(),
                Country = record[5].ToString(),
                Carrier = record[6].ToString(),
                Status = record[7].ToString(),
                Item = record[8].ToString(),
                Qty = record[9].ToString(),
                Value = record[10].ToString(),
                Discount = record[11].ToString(),
                LotId = record[12].ToString(),
                ExpiryDate = record[13].ToString(),
                ReferenceNo = record[14].ToString(),
                CustomerRef = record[15].ToString(),
                DateShpd = record[16].ToString(),
                ShpdFrom = record[17].ToString(),
                TrackingNo = record[18].ToString()
            };
        }
    }
}
