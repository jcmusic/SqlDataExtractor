using System;
using System.Data;

namespace YuStashSageX3_ETL.Models
{
    public class Vw_Item_Master : ICreatable<Vw_Item_Master>
    {
        #region Props

        char commaReplacementChar = '|';

        string _partNo;
        string _productDescription;
        string _customsProductDescription;
        string _channel;
        string _uPCCode;
        string _eAN;
        string _jAN;
        string _gTIN;
        string _sCC14;
        string _primaryCategory;
        string _secondaryCategory;
        string _tertiaryCategory;
        string _season;
        string _dept;
        string _class;
        string _size;
        string _color;
        string _productType;
        string _makeToOrderFlag;
        string _lifecycleFlag;
        string _startDate;
        string _endDate;
        string _lotIdFlag;
        string _batchIdFlag;
        string _serialNoFlag;
        string _hSCode;
        string _buyCost;
        string _sellPrice;
        string _multiCurrencyFlag;
        string _price_US;
        string _price_ENG;
        string _supplierPricingFlag;
        string _customerPricingFlag;
        string _isDualSourced;
        string _supplier;
        string _multiSupplierAllocationSplitPct;
        string _supplierPN;
        string _distiPN;
        string _customerPN;
        string _customer;
        string _cOO;
        string _warehouse;
        string _multiWarehouseAllocationSplitPct;
        string _isTempControlled;
        string _isSecureStored;
        string _uOM;
        string _unitLength_in;
        string _unitWidth_in;
        string _unitHeight_in;
        string _unitWeight_lbs;
        string _masterCartonQty;
        string _masterCartonLength_in;
        string _masterCartonWidth_in;
        string _masterCartonHeight_in;
        string _masterCartonWeight_lbs;
        string _palletQty;
        string _palletLength_in;
        string _palletWidth_in;
        string _palletHeight_in;
        string _palletWeight_lbs;
        string _masterCartonQtyPerPallet;
        string _masterCartonQtyPerPalletLayer;
        string _noLayersPerPallet;
        string _noPalletsPerFTL;
        string _fTLTruckType;
        string _noPalletsPerContainer;
        string _noMasterCasesPerContainer;
        string _noUnitsPerContainer;
        string _innerCaseQty;
        string _innerCaseLength_in;
        string _innerCaseWidth_in;
        string _innerCaseHeight_in;
        string _innerCaseWeight_lbs;
        string _custItem_Omni;


        public string TransactionId { get; set; }
        public string PartNo { get { return _partNo.Replace(',', commaReplacementChar); } set { _partNo = value; } }
        public string ProductDescription { get { return _productDescription.Replace(',', commaReplacementChar); } set { _productDescription = value; } }
        public string CustomsProductDescription { get { return _customsProductDescription.Replace(',', commaReplacementChar); } set { _customsProductDescription = value; } }
        public string Channel { get { return _channel.Replace(',', commaReplacementChar); } set { _channel = value; } }
        public string UPCCode { get { return _uPCCode.Replace(',', commaReplacementChar); } set { _uPCCode = value; } }
        public string EAN { get { return _eAN.Replace(',', commaReplacementChar); } set { _eAN = value; } }
        public string JAN { get { return _jAN.Replace(',', commaReplacementChar); } set { _jAN = value; } }
        public string GTIN { get { return _gTIN.Replace(',', commaReplacementChar); } set { _gTIN = value; } }
        public string SCC14 { get { return _sCC14.Replace(',', commaReplacementChar); } set { _sCC14 = value; } }
        public string PrimaryCategory { get { return _primaryCategory.Replace(',', commaReplacementChar); } set { _primaryCategory = value; } }
        public string SecondaryCategory { get { return _secondaryCategory.Replace(',', commaReplacementChar); } set { _secondaryCategory = value; } }
        public string TertiaryCategory { get { return _tertiaryCategory.Replace(',', commaReplacementChar); } set { _tertiaryCategory = value; } }
        public string Season { get { return _season.Replace(',', commaReplacementChar); } set { _season = value; } }
        public string Dept { get { return _dept.Replace(',', commaReplacementChar); } set { _dept = value; } }
        public string Class { get { return _class.Replace(',', commaReplacementChar); } set { _class = value; } }
        public string Size { get { return _size.Replace(',', commaReplacementChar); } set { _size = value; } }
        public string Color { get { return _color.Replace(',', commaReplacementChar); } set { _color = value; } }
        public string ProductType { get { return _productType.Replace(',', commaReplacementChar); } set { _productType = value; } }
        public string MakeToOrderFlag { get { return _makeToOrderFlag.Replace(',', commaReplacementChar); } set { _makeToOrderFlag = value; } }
        public string LifecycleFlag { get { return _lifecycleFlag.Replace(',', commaReplacementChar); } set { _lifecycleFlag = value; } }
        public string StartDate { get { return _startDate.Replace(',', commaReplacementChar); } set { _startDate = value; } }
        public string EndDate { get { return _endDate.Replace(',', commaReplacementChar); } set { _endDate = value; } }
        public string LotIdFlag { get { return _lotIdFlag.Replace(',', commaReplacementChar); } set { _lotIdFlag = value; } }
        public string BatchIdFlag { get { return _batchIdFlag.Replace(',', commaReplacementChar); } set { _batchIdFlag = value; } }
        public string SerialNoFlag { get { return _serialNoFlag.Replace(',', commaReplacementChar); } set { _serialNoFlag = value; } }
        public string HSCode { get { return _hSCode.Replace(',', commaReplacementChar); } set { _hSCode = value; } }
        public string BuyCost { get { return _buyCost.Replace(',', commaReplacementChar); } set { _buyCost = value; } }
        public string SellPrice { get { return _sellPrice.Replace(',', commaReplacementChar); } set { _sellPrice = value; } }
        public string MultiCurrencyFlag { get { return _multiCurrencyFlag.Replace(',', commaReplacementChar); } set { _multiCurrencyFlag = value; } }
        public string Price_US { get { return _price_US.Replace(',', commaReplacementChar); } set { _price_US = value; } }
        public string Price_ENG { get { return _price_ENG.Replace(',', commaReplacementChar); } set { _price_ENG = value; } }
        public string SupplierPricingFlag { get { return _supplierPricingFlag.Replace(',', commaReplacementChar); } set { _supplierPricingFlag = value; } }
        public string CustomerPricingFlag { get { return _customerPricingFlag.Replace(',', commaReplacementChar); } set { _customerPricingFlag = value; } }
        public string IsDualSourced { get { return _isDualSourced.Replace(',', commaReplacementChar); } set { _isDualSourced = value; } }
        public string Supplier { get { return _supplier.Replace(',', commaReplacementChar); } set { _supplier = value; } }
        public string MultiSupplierAllocationSplitPct { get { return _multiSupplierAllocationSplitPct.Replace(',', commaReplacementChar); } set { _multiSupplierAllocationSplitPct = value; } }
        public string SupplierPN { get { return _supplierPN.Replace(',', commaReplacementChar); } set { _supplierPN = value; } }
        public string DistiPN { get { return _distiPN.Replace(',', commaReplacementChar); } set { _distiPN = value; } }
        public string CustomerPN { get { return _customerPN.Replace(',', commaReplacementChar); } set { _customerPN = value; } }
        public string Customer { get { return _customer.Replace(',', commaReplacementChar); } set { _customer = value; } }
        public string COO { get { return _cOO.Replace(',', commaReplacementChar); } set { _cOO = value; } }
        public string Warehouse { get { return _warehouse.Replace(',', commaReplacementChar); } set { _warehouse = value; } }
        public string MultiWarehouseAllocationSplitPct { get { return _multiWarehouseAllocationSplitPct.Replace(',', commaReplacementChar); } set { _multiWarehouseAllocationSplitPct = value; } }
        public string IsTempControlled { get { return _isTempControlled.Replace(',', commaReplacementChar); } set { _isTempControlled = value; } }
        public string IsSecureStored { get { return _isSecureStored.Replace(',', commaReplacementChar); } set { _isSecureStored = value; } }
        public string UOM { get { return _uOM.Replace(',', commaReplacementChar); } set { _uOM = value; } }
        public string UnitLength_in { get { return _unitLength_in.Replace(',', commaReplacementChar); } set { _unitLength_in = value; } }
        public string UnitWidth_in { get { return _unitWidth_in.Replace(',', commaReplacementChar); } set { _unitWidth_in = value; } }
        public string UnitHeight_in { get { return _unitHeight_in.Replace(',', commaReplacementChar); } set { _unitHeight_in = value; } }
        public string UnitWeight_lbs { get { return _unitWeight_lbs.Replace(',', commaReplacementChar); } set { _unitWeight_lbs = value; } }
        public string MasterCartonQty { get { return _masterCartonQty.Replace(',', commaReplacementChar); } set { _masterCartonQty = value; } }
        public string MasterCartonLength_in { get { return _masterCartonLength_in.Replace(',', commaReplacementChar); } set { _masterCartonLength_in = value; } }
        public string MasterCartonWidth_in { get { return _masterCartonWidth_in.Replace(',', commaReplacementChar); } set { _masterCartonWidth_in = value; } }
        public string MasterCartonHeight_in { get { return _masterCartonHeight_in.Replace(',', commaReplacementChar); } set { _masterCartonHeight_in = value; } }
        public string MasterCartonWeight_lbs { get { return _masterCartonWeight_lbs.Replace(',', commaReplacementChar); } set { _masterCartonWeight_lbs = value; } }
        public string PalletQty { get { return _palletQty.Replace(',', commaReplacementChar); } set { _palletQty = value; } }
        public string PalletLength_in { get { return _palletLength_in.Replace(',', commaReplacementChar); } set { _palletLength_in = value; } }
        public string PalletWidth_in { get { return _palletWidth_in.Replace(',', commaReplacementChar); } set { _palletWidth_in = value; } }
        public string PalletHeight_in { get { return _palletHeight_in.Replace(',', commaReplacementChar); } set { _palletHeight_in = value; } }
        public string PalletWeight_lbs { get { return _palletWeight_lbs.Replace(',', commaReplacementChar); } set { _palletWeight_lbs = value; } }
        public string MasterCartonQtyPerPallet { get { return _masterCartonQtyPerPallet.Replace(',', commaReplacementChar); } set { _masterCartonQtyPerPallet = value; } }
        public string MasterCartonQtyPerPalletLayer { get { return _masterCartonQtyPerPalletLayer.Replace(',', commaReplacementChar); } set { _masterCartonQtyPerPalletLayer = value; } }
        public string NoLayersPerPallet { get { return _noLayersPerPallet.Replace(',', commaReplacementChar); } set { _noLayersPerPallet = value; } }
        public string NoPalletsPerFTL { get { return _noPalletsPerFTL.Replace(',', commaReplacementChar); } set { _noPalletsPerFTL = value; } }
        public string FTLTruckType { get { return _fTLTruckType.Replace(',', commaReplacementChar); } set { _fTLTruckType = value; } }
        public string NoPalletsPerContainer { get { return _noPalletsPerContainer.Replace(',', commaReplacementChar); } set { _noPalletsPerContainer = value; } }
        public string NoMasterCasesPerContainer { get { return _noMasterCasesPerContainer.Replace(',', commaReplacementChar); } set { _noMasterCasesPerContainer = value; } }
        public string NoUnitsPerContainer { get { return _noUnitsPerContainer.Replace(',', commaReplacementChar); } set { _noUnitsPerContainer = value; } }
        public string InnerCaseQty { get { return _innerCaseQty.Replace(',', commaReplacementChar); } set { _innerCaseQty = value; } }
        public string InnerCaseLength_in { get { return _innerCaseLength_in.Replace(',', commaReplacementChar); } set { _innerCaseLength_in = value; } }
        public string InnerCaseWidth_in { get { return _innerCaseWidth_in.Replace(',', commaReplacementChar); } set { _innerCaseWidth_in = value; } }
        public string InnerCaseHeight_in { get { return _innerCaseHeight_in.Replace(',', commaReplacementChar); } set { _innerCaseHeight_in = value; } }
        public string InnerCaseWeight_lbs { get { return _innerCaseWeight_lbs.Replace(',', commaReplacementChar); } set { _innerCaseWeight_lbs = value; } }
        public string CustItem_Omni { get { return _custItem_Omni.Replace(',', commaReplacementChar); } set { _custItem_Omni = value; } }
        #endregion

        public Vw_Item_Master Create(IDataRecord record, Guid transactionId)
        {
            return new Vw_Item_Master
            {
                TransactionId = transactionId.ToString(),
                PartNo = record[0].ToString(),
                ProductDescription = record[1].ToString(),
                CustomsProductDescription = record[2].ToString(),
                Channel = record[3].ToString(),
                UPCCode = record[4].ToString(),
                EAN = record[5].ToString(),
                JAN = record[6].ToString(),
                GTIN = record[7].ToString(),
                SCC14 = record[8].ToString(),
                PrimaryCategory = record[9].ToString(),
                SecondaryCategory = record[10].ToString(),
                TertiaryCategory = record[11].ToString(),
                Season = record[12].ToString(),
                Dept = record[13].ToString(),
                Class = record[14].ToString(),
                Size = record[15].ToString(),
                Color = record[16].ToString(),
                ProductType = record[17].ToString(),
                MakeToOrderFlag = record[18].ToString(),
                LifecycleFlag = record[19].ToString(),
                StartDate = record[20].ToString(),
                EndDate = record[21].ToString(),
                LotIdFlag = record[22].ToString(),
                BatchIdFlag = record[23].ToString(),
                SerialNoFlag = record[24].ToString(),
                HSCode = record[25].ToString(),
                BuyCost = record[26].ToString(),
                SellPrice = record[27].ToString(),
                MultiCurrencyFlag = record[28].ToString(),
                Price_US = record[29].ToString(),
                Price_ENG = record[30].ToString(),
                SupplierPricingFlag = record[31].ToString(),
                CustomerPricingFlag = record[32].ToString(),
                IsDualSourced = record[33].ToString(),
                Supplier = record[34].ToString(),
                MultiSupplierAllocationSplitPct = record[35].ToString(),
                SupplierPN = record[36].ToString(),
                DistiPN = record[37].ToString(),
                CustomerPN = record[38].ToString(),
                Customer = record[39].ToString(),
                COO = record[40].ToString(),
                Warehouse = record[41].ToString(),
                MultiWarehouseAllocationSplitPct = record[42].ToString(),
                IsTempControlled = record[43].ToString(),
                IsSecureStored = record[44].ToString(),
                UOM = record[45].ToString(),
                UnitLength_in = record[46].ToString(),
                UnitWidth_in = record[47].ToString(),
                UnitHeight_in = record[48].ToString(),
                UnitWeight_lbs = record[49].ToString(),
                MasterCartonQty = record[50].ToString(),
                MasterCartonLength_in = record[51].ToString(),
                MasterCartonWidth_in = record[52].ToString(),
                MasterCartonHeight_in = record[53].ToString(),
                MasterCartonWeight_lbs = record[54].ToString(),
                PalletQty = record[55].ToString(),
                PalletLength_in = record[56].ToString(),
                PalletWidth_in = record[57].ToString(),
                PalletHeight_in = record[58].ToString(),
                PalletWeight_lbs = record[59].ToString(),
                MasterCartonQtyPerPallet = record[60].ToString(),
                MasterCartonQtyPerPalletLayer = record[61].ToString(),
                NoLayersPerPallet = record[62].ToString(),
                NoPalletsPerFTL = record[63].ToString(),
                FTLTruckType = record[64].ToString(),
                NoPalletsPerContainer = record[65].ToString(),
                NoMasterCasesPerContainer = record[66].ToString(),
                NoUnitsPerContainer = record[67].ToString(),
                InnerCaseQty = record[68].ToString(),
                InnerCaseLength_in = record[69].ToString(),
                InnerCaseWidth_in = record[70].ToString(),
                InnerCaseHeight_in = record[71].ToString(),
                InnerCaseWeight_lbs = record[72].ToString(),
                CustItem_Omni = record[73].ToString()
            };
        }
    }
}
