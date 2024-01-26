using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    public class Vw_Supplier_Constraints : ICreatable<Vw_Supplier_Constraints>
    {
        #region Props

        char commaReplacementChar = '|';

        string _supplier;
        string _productType;
        string _primaryCategory;
        string _partNo;
        string _description;
        string _mOQ;
        string _cPC_RuleLevel;
        string _capacityMax_Weekly;
        string _eOQ;
        string _leadTime_For_FirstOrder_CalendarDays;
        string _leadTime_For_Reorder_CalendarDays;
        string _shippingLeadTime_CalendarDays;
        string _dSI_Target_CalendarDays;
        string _dSI_Min;
        string _dSI_Max;



        public string TransactionId { get; set; }
        public string Supplier { get { return _supplier.Replace(',', commaReplacementChar); } set { _supplier = value; } }
        public string ProductType { get { return _productType.Replace(',', commaReplacementChar); } set { _productType = value; } }
        public string PrimaryCategory { get { return _primaryCategory.Replace(',', commaReplacementChar); } set { _primaryCategory = value; } }
        public string PartNo { get { return _partNo.Replace(',', commaReplacementChar); } set { _partNo = value; } }
        public string Description { get { return _description.Replace(',', commaReplacementChar); } set { _description = value; } }
        public string MOQ { get { return _mOQ.Replace(',', commaReplacementChar); } set { _mOQ = value; } }
        public string CPC_RuleLevel { get { return _cPC_RuleLevel.Replace(',', commaReplacementChar); } set { _cPC_RuleLevel = value; } }
        public string CapacityMax_Weekly { get { return _capacityMax_Weekly.Replace(',', commaReplacementChar); } set { _capacityMax_Weekly = value; } }
        public string EOQ { get { return _eOQ.Replace(',', commaReplacementChar); } set { _eOQ = value; } }
        public string LeadTime_For_FirstOrder_CalendarDays { get { return _leadTime_For_FirstOrder_CalendarDays.Replace(',', commaReplacementChar); } set { _leadTime_For_FirstOrder_CalendarDays = value; } }
        public string LeadTime_For_Reorder_CalendarDays { get { return _leadTime_For_Reorder_CalendarDays.Replace(',', commaReplacementChar); } set { _leadTime_For_Reorder_CalendarDays = value; } }
        public string ShippingLeadTime_CalendarDays { get { return _shippingLeadTime_CalendarDays.Replace(',', commaReplacementChar); } set { _shippingLeadTime_CalendarDays = value; } }
        public string DSI_Target_CalendarDays { get { return _dSI_Target_CalendarDays.Replace(',', commaReplacementChar); } set { _dSI_Target_CalendarDays = value; } }
        public string DSI_Min { get { return _dSI_Min.Replace(',', commaReplacementChar); } set { _dSI_Min = value; } }
        public string DSI_Max { get { return _dSI_Max.Replace(',', commaReplacementChar); } set { _dSI_Max = value; } }

        #endregion

        public Vw_Supplier_Constraints Create(IDataRecord record, Guid transactionId)
        {
            //[Supplier], [Product Type], [Primary Category], [Part No], [Description],
            //[MOQ], [CPC Rule - Level], [Cum. Production Capacity Max (Weekly)], [EOQ],
            //[Lead-Time for 1st order (calendar days)], [Lead-Time for Reorder (calendar days)],
            //[Shipping Lead Time (Cal. Days)], [DSI Target (calendar days)], [DSI Min], [DSI Max]

            return new Vw_Supplier_Constraints
            {
                TransactionId = transactionId.ToString(),
                Supplier = record[0].ToString(),
                ProductType = record[1].ToString(),
                PrimaryCategory = record[2].ToString(),
                PartNo = record[3].ToString(),
                Description = record[4].ToString(),
                MOQ = record[5].ToString(),
                CPC_RuleLevel = record[6].ToString(),
                CapacityMax_Weekly = record[8].ToString(),
                EOQ = record[9].ToString(),
                LeadTime_For_FirstOrder_CalendarDays = record[10].ToString(),
                LeadTime_For_Reorder_CalendarDays = record[11].ToString(),
                ShippingLeadTime_CalendarDays = record[12].ToString(),
                DSI_Target_CalendarDays = record[13].ToString(),
                DSI_Min = record[14].ToString(),
                DSI_Max = record[15].ToString()
            };
        }
    }
}
