using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    public class Vw_Bom_Master : ICreatable<Vw_Bom_Master>
    {
        #region Props

        char commaReplacementChar = '|';

        string _bAPartNo;
        string _version;
        string _validFrom;
        string _validTo;
        string _lifecycle;
        string _status;
        string _componentLevel;
        string _sequence;
        string _rMPartNo;
        string _description;
        string _usage;
        string _unitCost;
        string _isPkgItem;
        string _mVA;
        string _isMVA;
        string _specialServices;
        string _isSpecialService;
        string _isAlternateItem;
        string _rule;
        string _min;
        string _max;
        string _ranking;
        string _custRecordOmni;


        public string TransactionId { get; set; }
        public string BAPartNo { get { return _bAPartNo.Replace(',', commaReplacementChar); } set { _bAPartNo = value; } }
        public string Version { get { return _version.Replace(',', commaReplacementChar); } set { _version = value; } }
        public string ValidFrom { get { return _validFrom.Replace(',', commaReplacementChar); } set { _validFrom = value; } }
        public string ValidTo { get { return _validTo.Replace(',', commaReplacementChar); } set { _validTo = value; } }
        public string Lifecycle { get { return _lifecycle.Replace(',', commaReplacementChar); } set { _lifecycle = value; } }
        public string Status { get { return _status.Replace(',', commaReplacementChar); } set { _status = value; } }
        public string ComponentLevel { get { return _componentLevel.Replace(',', commaReplacementChar); } set { _componentLevel = value; } }
        public string Sequence { get { return _sequence.Replace(',', commaReplacementChar); } set { _sequence = value; } }
        public string RMPartNo { get { return _rMPartNo.Replace(',', commaReplacementChar); } set { _rMPartNo = value; } }
        public string Description { get { return _description.Replace(',', commaReplacementChar); } set { _description = value; } }
        public string Usage { get { return _usage.Replace(',', commaReplacementChar); } set { _usage = value; } }
        public string UnitCost { get { return _unitCost.Replace(',', commaReplacementChar); } set { _unitCost = value; } }
        public string IsPkgItem { get { return _isPkgItem.Replace(',', commaReplacementChar); } set { _isPkgItem = value; } }
        public string MVA { get { return _mVA.Replace(',', commaReplacementChar); } set { _mVA = value; } }
        public string IsMVA { get { return _isMVA.Replace(',', commaReplacementChar); } set { _isMVA = value; } }
        public string SpecialServices { get { return _specialServices.Replace(',', commaReplacementChar); } set { _specialServices = value; } }
        public string IsSpecialService { get { return _isSpecialService.Replace(',', commaReplacementChar); } set { _isSpecialService = value; } }
        public string IsAlternateItem { get { return _isAlternateItem.Replace(',', commaReplacementChar); } set { _isAlternateItem = value; } }
        public string Rule { get { return _rule.Replace(',', commaReplacementChar); } set { _rule = value; } }
        public string Min { get { return _min.Replace(',', commaReplacementChar); } set { _min = value; } }
        public string Max { get { return _max.Replace(',', commaReplacementChar); } set { _max = value; } }
        public string Ranking { get { return _ranking.Replace(',', commaReplacementChar); } set { _ranking = value; } }
        public string CustRecordOmni { get { return _custRecordOmni.Replace(',', commaReplacementChar); } set { _custRecordOmni = value; } }

        #endregion

        public Vw_Bom_Master Create(IDataRecord record, Guid transactionId)
        {
            //public const string ZOMNI_BOM_MASTER_HEADERS = "BA Part No.,Version,Valid From,Valid To,Lifecycle,Status,Component Level,Sequence,RM Part No.,Description,Usage,Unit Cost,Is Pkg Item,MVA $,Is MVA,Special Services $,Is Special Service,Is Alternate Item,Rule,Min,Max,Ranking,custrecord_omni";

            return new Vw_Bom_Master
            {
                TransactionId = transactionId.ToString(),
                BAPartNo = record[0].ToString(),
                Version = record[1].ToString(),
                ValidFrom = record[2].ToString(),
                ValidTo = record[3].ToString(),
                Lifecycle = record[4].ToString(),
                Status = record[5].ToString(),
                ComponentLevel = record[6].ToString(),
                Sequence = record[7].ToString(),
                RMPartNo = record[8].ToString(),
                Description = record[9].ToString(),
                Usage = record[10].ToString(),
                UnitCost = record[11].ToString(),
                IsPkgItem = record[12].ToString(),
                MVA = record[13].ToString(),
                IsMVA = record[14].ToString(),
                SpecialServices = record[15].ToString(),
                IsSpecialService = record[16].ToString(),
                IsAlternateItem = record[17].ToString(),
                Rule = record[18].ToString(),
                Min = record[19].ToString(),
                Max = record[20].ToString(),
                Ranking = record[21].ToString(),
                CustRecordOmni = record[22].ToString()
            };
        }
    }
}
