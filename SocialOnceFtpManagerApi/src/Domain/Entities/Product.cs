using EAProductService.Domain.Common;
using EAProductService.Domain.Enums;
using System;

namespace EAProductService.Domain.Entities
{
    public class Product : AuditableEntity
    {

        public int Id { get; set; }


        #region Navision Fields

        /// <summary>
        /// Gets or sets the no.
        /// </summary>
        /// <value>
        /// The no.
        /// </value>
        public string No { get; set; } // Custom
        /// <summary>
        /// Gets or sets the no2.
        /// </summary>
        /// <value>
        /// The no2.
        /// </value>
        public string No2 { get; set; } // Custom
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; } // Custom
        /// <summary>
        /// Gets or sets the search description.
        /// </summary>
        /// <value>
        /// The search description.
        /// </value>
        public string SearchDescription { get; set; } // Custom
        /// <summary>
        /// Gets or sets the description2.
        /// </summary>
        /// <value>
        /// The description2.
        /// </value>
        public string Description2 { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is assembly bom.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is assembly bom; otherwise, <c>false</c>.
        /// </value>
        public bool IsAssemblyBom { get; set; }
        /// <summary>
        /// Gets or sets the base unit of measure.
        /// </summary>
        /// <value>
        /// The base unit of measure.
        /// </value>
        public string BaseUnitOfMeasure { get; set; } // Custom
        /// <summary>
        /// Gets or sets the price unit conversion.
        /// </summary>
        /// <value>
        /// The price unit conversion.
        /// </value>
        public int PriceUnitConversion { get; set; }
        /// <summary>
        /// Gets or sets the type of the product.
        /// </summary>
        /// <value>
        /// The type of the product.
        /// </value>

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the inventory posting group.
        /// </summary>
        /// <value>
        /// The inventory posting group.
        /// </value>
        public string InventoryPostingGroup { get; set; } // Custom
        /// <summary>
        /// Gets or sets the shelf no.
        /// </summary>
        /// <value>
        /// The shelf no.
        /// </value>
        public string ShelfNo { get; set; } // Custom
        /// <summary>
        /// Gets or sets the item disc group.
        /// </summary>
        /// <value>
        /// The item disc group.
        /// </value>
        public string ItemDiscGroup { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [allows invoice discount].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allows invoice discount]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowsInvoiceDiscount { get; set; } // Custom
        /// <summary>
        /// Gets or sets the statistics group.
        /// </summary>
        /// <value>
        /// The statistics group.
        /// </value>
        public int StatisticsGroup { get; set; } // Custom
        /// <summary>
        /// Gets or sets the commission group.
        /// </summary>
        /// <value>
        /// The commission group.
        /// </value>
        public int CommissionGroup { get; set; }
        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>
        /// The unit price.
        /// </value>
        public decimal UnitPrice { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the price profit calculation.
        /// </summary>
        /// <value>
        /// The type of the price profit calculation.
        /// </value>
        public int PriceProfitCalculationTypeId { get; set; }
        public PriceProfitCalculationType PriceProfitCalculationType { get; set; }
        /// <summary>
        /// Gets or sets the profit percentage.
        /// </summary>
        /// <value>
        /// The profit percentage.
        /// </value>
        public decimal ProfitPercentage { get; set; }
        /// <summary>
        /// Gets or sets the type of the costing method.
        /// </summary>
        /// <value>
        /// The type of the costing method.
        /// </value>
        public int CostingMethodTypeId { get; set; }
        public CostingMethodType CostingMethodType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the unit cost.
        /// </summary>
        /// <value>
        /// The unit cost.
        /// </value>
        public decimal UnitCost { get; set; } // Custom
        /// <summary>
        /// Gets or sets the standard cost.
        /// </summary>
        /// <value>
        /// The standard cost.
        /// </value>
        public decimal StandardCost { get; set; }
        /// <summary>
        /// Gets or sets the last direct cost.
        /// </summary>
        /// <value>
        /// The last direct cost.
        /// </value>
        public decimal LastDirectCost { get; set; } // Custom
        /// <summary>
        /// Gets or sets the indirect cost percentage.
        /// </summary>
        /// <value>
        /// The indirect cost percentage.
        /// </value>
        public decimal IndirectCostPercentage { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is cost adjusted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is cost adjusted; otherwise, <c>false</c>.
        /// </value>
        public bool IsCostAdjusted { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [allow online adjustment].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow online adjustment]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowOnlineAdjustment { get; set; }
        /// <summary>
        /// Gets or sets the vendor no.
        /// </summary>
        /// <value>
        /// The vendor no.
        /// </value>
        public string VendorNo { get; set; } // Custom
        /// <summary>
        /// Gets or sets the vendor item no.
        /// </summary>
        /// <value>
        /// The vendor item no.
        /// </value>
        public string VendorItemNo { get; set; } // Custom
        /// <summary>
        /// Gets or sets the lead time calculation.
        /// </summary>
        /// <value>
        /// The lead time calculation.
        /// </value>
        public string LeadTimeCalculation { get; set; }
        /// <summary>
        /// Gets or sets the reorder point.
        /// </summary>
        /// <value>
        /// The reorder point.
        /// </value>
        public decimal ReorderPoint { get; set; } // Custom
        /// <summary>
        /// Gets or sets the maximum inventory.
        /// </summary>
        /// <value>
        /// The maximum inventory.
        /// </value>
        public decimal MaximumInventory { get; set; } // Custom
        /// <summary>
        /// Gets or sets the reorder quantity.
        /// </summary>
        /// <value>
        /// The reorder quantity.
        /// </value>
        public decimal ReorderQuantity { get; set; } // Custom
        /// <summary>
        /// Gets or sets the alternative item no.
        /// </summary>
        /// <value>
        /// The alternative item no.
        /// </value>
        public string AlternativeItemNo { get; set; }
        /// <summary>
        /// Gets or sets the unit list price.
        /// </summary>
        /// <value>
        /// The unit list price.
        /// </value>
        public decimal UnitListPrice { get; set; }
        /// <summary>
        /// Gets or sets the duty due percentage.
        /// </summary>
        /// <value>
        /// The duty due percentage.
        /// </value>
        public decimal DutyDuePercentage { get; set; }
        /// <summary>
        /// Gets or sets the duty code.
        /// </summary>
        /// <value>
        /// The duty code.
        /// </value>
        public string DutyCode { get; set; }
        /// <summary>
        /// Gets or sets the gross weight.
        /// </summary>
        /// <value>
        /// The gross weight.
        /// </value>
        public decimal GrossWeight { get; set; } // Custom
        /// <summary>
        /// Gets or sets the net weight.
        /// </summary>
        /// <value>
        /// The net weight.
        /// </value>
        public decimal NetWeight { get; set; } // Custom
        /// <summary>
        /// Gets or sets the units per parcel.
        /// </summary>
        /// <value>
        /// The units per parcel.
        /// </value>
        public decimal UnitsPerParcel { get; set; }
        /// <summary>
        /// Gets or sets the unit volume.
        /// </summary>
        /// <value>
        /// The unit volume.
        /// </value>
        public decimal UnitVolume { get; set; } // Custom
        /// <summary>
        /// Gets or sets the durability.
        /// </summary>
        /// <value>
        /// The durability.
        /// </value>
        public string Durability { get; set; }
        /// <summary>
        /// Gets or sets the type of the freight.
        /// </summary>
        /// <value>
        /// The type of the freight.
        /// </value>
        public string FreightType { get; set; }
        /// <summary>
        /// Gets or sets the tariff no.
        /// </summary>
        /// <value>
        /// The tariff no.
        /// </value>
        public string TariffNo { get; set; } // Custom
        /// <summary>
        /// Gets or sets the duty unit conversion.
        /// </summary>
        /// <value>
        /// The duty unit conversion.
        /// </value>
        public decimal DutyUnitConversion { get; set; }
        /// <summary>
        /// Gets or sets the country region purchased code.
        /// </summary>
        /// <value>
        /// The country region purchased code.
        /// </value>
        public string CountryRegionPurchasedCode { get; set; }
        /// <summary>
        /// Gets or sets the budget quantity.
        /// </summary>
        /// <value>
        /// The budget quantity.
        /// </value>
        public decimal BudgetQuantity { get; set; }
        /// <summary>
        /// Gets or sets the budgeted amount.
        /// </summary>
        /// <value>
        /// The budgeted amount.
        /// </value>
        public decimal BudgetedAmount { get; set; }
        /// <summary>
        /// Gets or sets the budget profit.
        /// </summary>
        /// <value>
        /// The budget profit.
        /// </value>
        public decimal BudgetProfit { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has comments.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has comments; otherwise, <c>false</c>.
        /// </value>
        public bool HasComments { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is blocked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is blocked; otherwise, <c>false</c>.
        /// </value>
        public bool IsBlocked { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether [cost is posted to gl].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [cost is posted to gl]; otherwise, <c>false</c>.
        /// </value>
        public bool CostIsPostedToGl { get; set; }
        /// <summary>
        /// Gets or sets the last date modified.
        /// </summary>
        /// <value>
        /// The last date modified.
        /// </value>
        public DateTime LastDateModified { get; set; } // Custom
        /// <summary>
        /// Gets or sets the date filter.
        /// </summary>
        /// <value>
        /// The date filter.
        /// </value>
        public DateTime DateFilter { get; set; }
        /// <summary>
        /// Gets or sets the global dimension1 filter.
        /// </summary>
        /// <value>
        /// The global dimension1 filter.
        /// </value>
        public string GlobalDimension1Filter { get; set; }
        /// <summary>
        /// Gets or sets the global dimension2 filter.
        /// </summary>
        /// <value>
        /// The global dimension2 filter.
        /// </value>
        public string GlobalDimension2Filter { get; set; }
        /// <summary>
        /// Gets or sets the location filter.
        /// </summary>
        /// <value>
        /// The location filter.
        /// </value>
        public string LocationFilter { get; set; }
        /// <summary>
        /// Gets or sets the inventory.
        /// </summary>
        /// <value>
        /// The inventory.
        /// </value>
        public decimal Inventory { get; set; }
        /// <summary>
        /// Gets or sets the net invoiced qty.
        /// </summary>
        /// <value>
        /// The net invoiced qty.
        /// </value>
        public decimal NetInvoicedQty { get; set; }
        /// <summary>
        /// Gets or sets the net change.
        /// </summary>
        /// <value>
        /// The net change.
        /// </value>
        public decimal NetChange { get; set; }
        /// <summary>
        /// Gets or sets the purchases qty.
        /// </summary>
        /// <value>
        /// The purchases qty.
        /// </value>
        public decimal PurchasesQty { get; set; }
        /// <summary>
        /// Gets or sets the sales qty.
        /// </summary>
        /// <value>
        /// The sales qty.
        /// </value>
        public decimal SalesQty { get; set; }
        /// <summary>
        /// Gets or sets the positive adjustment qty.
        /// </summary>
        /// <value>
        /// The positive adjustment qty.
        /// </value>
        public decimal PositiveAdjustmentQty { get; set; }
        /// <summary>
        /// Gets or sets the negative adjustment qty.
        /// </summary>
        /// <value>
        /// The negative adjustment qty.
        /// </value>
        public decimal NegativeAdjustmentQty { get; set; }
        /// <summary>
        /// Gets or sets the purchases lcy.
        /// </summary>
        /// <value>
        /// The purchases lcy.
        /// </value>
        public decimal PurchasesLcy { get; set; }
        /// <summary>
        /// Gets or sets the sales lcy.
        /// </summary>
        /// <value>
        /// The sales lcy.
        /// </value>
        public decimal SalesLcy { get; set; }
        /// <summary>
        /// Gets or sets the positive adjustment lcy.
        /// </summary>
        /// <value>
        /// The positive adjustment lcy.
        /// </value>
        public decimal PositiveAdjustmentLcy { get; set; }
        /// <summary>
        /// Gets or sets the negative adjustment lcy.
        /// </summary>
        /// <value>
        /// The negative adjustment lcy.
        /// </value>
        public decimal NegativeAdjustmentLcy { get; set; }
        /// <summary>
        /// Gets or sets the cogs lcy.
        /// </summary>
        /// <value>
        /// The cogs lcy.
        /// </value>
        public decimal CogsLcy { get; set; }
        /// <summary>
        /// Gets or sets the qty on purchase order.
        /// </summary>
        /// <value>
        /// The qty on purchase order.
        /// </value>
        public decimal QtyOnPurchaseOrder { get; set; }
        /// <summary>
        /// Gets or sets the qty on sales order.
        /// </summary>
        /// <value>
        /// The qty on sales order.
        /// </value>
        public decimal QtyOnSalesOrder { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [price includes vat].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [price includes vat]; otherwise, <c>false</c>.
        /// </value>
        public bool PriceIncludesVat { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [drop shipment filter].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [drop shipment filter]; otherwise, <c>false</c>.
        /// </value>
        public bool DropShipmentFilter { get; set; }
        /// <summary>
        /// Gets or sets the vat bus posting gr price.
        /// </summary>
        /// <value>
        /// The vat bus posting gr price.
        /// </value>
        public string VatBusPostingGrPrice { get; set; }
        /// <summary>
        /// Gets or sets the gen product posting group.
        /// </summary>
        /// <value>
        /// The gen product posting group.
        /// </value>
        public string GenProdPostingGroup { get; set; } // Custom
        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>
        /// The picture.
        /// </value>
        public string Picture { get; set; }
        /// <summary>
        /// Gets or sets the transferred qty.
        /// </summary>
        /// <value>
        /// The transferred qty.
        /// </value>
        public decimal TransferredQty { get; set; }
        /// <summary>
        /// Gets or sets the transferred lcy.
        /// </summary>
        /// <value>
        /// The transferred lcy.
        /// </value>
        public decimal TransferredLcy { get; set; }
        /// <summary>
        /// Gets or sets the country region of origin code.
        /// </summary>
        /// <value>
        /// The country region of origin code.
        /// </value>
        public string CountryRegionOfOriginCode { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [automatic ext texts].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic ext texts]; otherwise, <c>false</c>.
        /// </value>
        public bool AutomaticExtTexts { get; set; }
        /// <summary>
        /// Gets or sets the no series.
        /// </summary>
        /// <value>
        /// The no series.
        /// </value>
        public string NoSeries { get; set; }
        /// <summary>
        /// Gets or sets the tax group code.
        /// </summary>
        /// <value>
        /// The tax group code.
        /// </value>
        public string TaxGroupCode { get; set; }
        /// <summary>
        /// Gets or sets the vat product posting group.
        /// </summary>
        /// <value>
        /// The vat product posting group.
        /// </value>
        public string VatProdPostingGroup { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the reserve.
        /// </summary>
        /// <value>
        /// The type of the reserve.
        /// </value>
        public int ReserveTypeId { get; set; }
        public ReserveType ReserveType { get; set; }
        /// <summary>
        /// Gets or sets the reserved qty on inventory.
        /// </summary>
        /// <value>
        /// The reserved qty on inventory.
        /// </value>
        public decimal ReservedQtyOnInventory { get; set; }
        /// <summary>
        /// Gets or sets the reserved qty on purchases orders.
        /// </summary>
        /// <value>
        /// The reserved qty on purchases orders.
        /// </value>
        public decimal ReservedQtyOnPurchasesOrders { get; set; }
        /// <summary>
        /// Gets or sets the reserved qty on sales orders.
        /// </summary>
        /// <value>
        /// The reserved qty on sales orders.
        /// </value>
        public decimal ReservedQtyOnSalesOrders { get; set; }
        /// <summary>
        /// Gets or sets the global dimension1 code.
        /// </summary>
        /// <value>
        /// The global dimension1 code.
        /// </value>
        public string GlobalDimension1Code { get; set; }
        /// <summary>
        /// Gets or sets the global dimension2 code.
        /// </summary>
        /// <value>
        /// The global dimension2 code.
        /// </value>
        public string GlobalDimension2Code { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on outbound transfer.
        /// </summary>
        /// <value>
        /// The resource qty on outbound transfer.
        /// </value>
        public decimal ResQtyOnOutboundTransfer { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on inbound transfer.
        /// </summary>
        /// <value>
        /// The resource qty on inbound transfer.
        /// </value>
        public decimal ResQtyOnInboundTransfer { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on sales returns.
        /// </summary>
        /// <value>
        /// The resource qty on sales returns.
        /// </value>
        public decimal ResQtyOnSalesReturns { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on purchases returns.
        /// </summary>
        /// <value>
        /// The resource qty on purchases returns.
        /// </value>
        public decimal ResQtyOnPurchasesReturns { get; set; }
        /// <summary>
        /// Gets or sets the type of the stock out warning.
        /// </summary>
        /// <value>
        /// The type of the stock out warning.
        /// </value>
        public int StockOutWarningTypeId { get; set; }
        public StockOutWarningType StockOutWarningType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the prevent negative inventory.
        /// </summary>
        /// <value>
        /// The type of the prevent negative inventory.
        /// </value>
        public int PreventNegativeInventoryTypeId { get; set; }
        public PreventNegativeInventoryType PreventNegativeInventoryType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the cost of open production orders.
        /// </summary>
        /// <value>
        /// The cost of open production orders.
        /// </value>
        public decimal CostOfOpenProductionOrders { get; set; }
        /// <summary>
        /// Gets or sets the application WKSH user identifier.
        /// </summary>
        /// <value>
        /// The application WKSH user identifier.
        /// </value>
        public string ApplicationWkshUserId { get; set; }
        /// <summary>
        /// Gets or sets the type of the assembly policy.
        /// </summary>
        /// <value>
        /// The type of the assembly policy.
        /// </value>
        public int AssemblyPolicyTypeId { get; set; }
        public AssemblyPolicyType AssemblyPolicyType { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on assembly order.
        /// </summary>
        /// <value>
        /// The resource qty on assembly order.
        /// </value>
        public decimal ResQtyOnAssemblyOrder { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on asm comp.
        /// </summary>
        /// <value>
        /// The resource qty on asm comp.
        /// </value>
        public decimal ResQtyOnAsmComp { get; set; }
        /// <summary>
        /// Gets or sets the qty on assembly order.
        /// </summary>
        /// <value>
        /// The qty on assembly order.
        /// </value>
        public decimal QtyOnAssemblyOrder { get; set; }
        /// <summary>
        /// Gets or sets the qty on asm component.
        /// </summary>
        /// <value>
        /// The qty on asm component.
        /// </value>
        public decimal QtyOnAsmComponent { get; set; }
        /// <summary>
        /// Gets or sets the qty on job order.
        /// </summary>
        /// <value>
        /// The qty on job order.
        /// </value>
        public decimal QtyOnJobOrder { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on job order.
        /// </summary>
        /// <value>
        /// The resource qty on job order.
        /// </value>
        public decimal ResQtyOnJobOrder { get; set; }
        /// <summary>
        /// Gets or sets the gtin.
        /// </summary>
        /// <value>
        /// The gtin.
        /// </value>
        public string Gtin { get; set; }
        /// <summary>
        /// Gets or sets the default deferral template code.
        /// </summary>
        /// <value>
        /// The default deferral template code.
        /// </value>
        public string DefaultDeferralTemplateCode { get; set; }
        /// <summary>
        /// Gets or sets the low level code.
        /// </summary>
        /// <value>
        /// The low level code.
        /// </value>
        public int LowLevelCode { get; set; }
        /// <summary>
        /// Gets or sets the size of the lot.
        /// </summary>
        /// <value>
        /// The size of the lot.
        /// </value>
        public decimal LotSize { get; set; }
        /// <summary>
        /// Gets or sets the serial nos.
        /// </summary>
        /// <value>
        /// The serial nos.
        /// </value>
        public string SerialNos { get; set; }
        /// <summary>
        /// Gets or sets the last unit cost calculate date.
        /// </summary>
        /// <value>
        /// The last unit cost calculate date.
        /// </value>
        public DateTime LastUnitCostCalcDate { get; set; }
        /// <summary>
        /// Gets or sets the rolled up material cost.
        /// </summary>
        /// <value>
        /// The rolled up material cost.
        /// </value>
        public decimal RolledUpMaterialCost { get; set; }
        /// <summary>
        /// Gets or sets the rolled up capacity cost.
        /// </summary>
        /// <value>
        /// The rolled up capacity cost.
        /// </value>
        public decimal RolledUpCapacityCost { get; set; }
        /// <summary>
        /// Gets or sets the scrap percentage.
        /// </summary>
        /// <value>
        /// The scrap percentage.
        /// </value>
        public decimal ScrapPercentage { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [inventory value zero].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [inventory value zero]; otherwise, <c>false</c>.
        /// </value>
        public bool InventoryValueZero { get; set; } // Custom
        /// <summary>
        /// Gets or sets the discrete order quantity.
        /// </summary>
        /// <value>
        /// The discrete order quantity.
        /// </value>
        public int DiscreteOrderQuantity { get; set; } // Custom
        /// <summary>
        /// Gets or sets the minimum order quantity.
        /// </summary>
        /// <value>
        /// The minimum order quantity.
        /// </value>
        public decimal MinimumOrderQuantity { get; set; } // Custom
        /// <summary>
        /// Gets or sets the maximum order quantity.
        /// </summary>
        /// <value>
        /// The maximum order quantity.
        /// </value>
        public decimal MaximumOrderQuantity { get; set; } // Custom
        /// <summary>
        /// Gets or sets the safety stock quantity.
        /// </summary>
        /// <value>
        /// The safety stock quantity.
        /// </value>
        public decimal SafetyStockQuantity { get; set; } // Custom
        /// <summary>
        /// Gets or sets the order multiple.
        /// </summary>
        /// <value>
        /// The order multiple.
        /// </value>
        public decimal OrderMultiple { get; set; } // Custom
        /// <summary>
        /// Gets or sets the safety lead time.
        /// </summary>
        /// <value>
        /// The safety lead time.
        /// </value>
        public string SafetyLeadTime { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the flushing method.
        /// </summary>
        /// <value>
        /// The type of the flushing method.
        /// </value>
        public int FlushingMethodTypeId { get; set; }
        public FlushingMethodType FlushingMethodType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the replenishment system.
        /// </summary>
        /// <value>
        /// The type of the replenishment system.
        /// </value>
        public int ReplenishmentSystemTypeId { get; set; }
        public ReplenishmentSystemType ReplenishmentSystemType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the scheduled receipt qty.
        /// </summary>
        /// <value>
        /// The scheduled receipt qty.
        /// </value>
        public decimal ScheduledReceiptQty { get; set; }
        /// <summary>
        /// Gets or sets the scheduled need qty.
        /// </summary>
        /// <value>
        /// The scheduled need qty.
        /// </value>
        public decimal ScheduledNeedQty { get; set; }
        /// <summary>
        /// Gets or sets the rounding precision.
        /// </summary>
        /// <value>
        /// The rounding precision.
        /// </value>
        public decimal RoundingPrecision { get; set; } // Custom
        /// <summary>
        /// Gets or sets the bin filter.
        /// </summary>
        /// <value>
        /// The bin filter.
        /// </value>
        public string BinFilter { get; set; }
        /// <summary>
        /// Gets or sets the variant filter.
        /// </summary>
        /// <value>
        /// The variant filter.
        /// </value>
        public string VariantFilter { get; set; }
        /// <summary>
        /// Gets or sets the sales unit of measure.
        /// </summary>
        /// <value>
        /// The sales unit of measure.
        /// </value>
        public string SalesUnitOfMeasure { get; set; } // Custom
        /// <summary>
        /// Gets or sets the purchase unit of measure.
        /// </summary>
        /// <value>
        /// The purchase unit of measure.
        /// </value>
        public string PurchaseUnitOfMeasure { get; set; } // Custom
        /// <summary>
        /// Gets or sets the time bucket.
        /// </summary>
        /// <value>
        /// The time bucket.
        /// </value>
        public string TimeBucket { get; set; }
        /// <summary>
        /// Gets or sets the reserved qty on product order.
        /// </summary>
        /// <value>
        /// The reserved qty on product order.
        /// </value>
        public decimal ReservedQtyOnProdOrder { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on product order comp.
        /// </summary>
        /// <value>
        /// The resource qty on product order comp.
        /// </value>
        public decimal ResQtyOnProdOrderComp { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on req line.
        /// </summary>
        /// <value>
        /// The resource qty on req line.
        /// </value>
        public decimal ResQtyOnReqLine { get; set; }
        /// <summary>
        /// Gets or sets the type of the reordering policy.
        /// </summary>
        /// <value>
        /// The type of the reordering policy.
        /// </value>
        public int ReorderingPolicyTypeId { get; set; }
        public ReorderingPolicyType ReorderingPolicyType { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether [includes inventory].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [includes inventory]; otherwise, <c>false</c>.
        /// </value>
        public bool IncludesInventory { get; set; }
        /// <summary>
        /// Gets or sets the type of the manufacturing policy.
        /// </summary>
        /// <value>
        /// The type of the manufacturing policy.
        /// </value>
        public int ManufacturingPolicyTypeId { get; set; }
        public ManufacturingPolicyType ManufacturingPolicyType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the rescheduling period.
        /// </summary>
        /// <value>
        /// The rescheduling period.
        /// </value>
        public string ReschedulingPeriod { get; set; }
        /// <summary>
        /// Gets or sets the lot accumulation period.
        /// </summary>
        /// <value>
        /// The lot accumulation period.
        /// </value>
        public string LotAccumulationPeriod { get; set; }
        /// <summary>
        /// Gets or sets the dampener period.
        /// </summary>
        /// <value>
        /// The dampener period.
        /// </value>
        public string DampenerPeriod { get; set; }
        /// <summary>
        /// Gets or sets the dampener quantity.
        /// </summary>
        /// <value>
        /// The dampener quantity.
        /// </value>
        public decimal DampenerQuantity { get; set; }
        /// <summary>
        /// Gets or sets the overflow level.
        /// </summary>
        /// <value>
        /// The overflow level.
        /// </value>
        public decimal OverflowLevel { get; set; }
        /// <summary>
        /// Gets or sets the planning transfer ship qty.
        /// </summary>
        /// <value>
        /// The planning transfer ship qty.
        /// </value>
        public decimal PlanningTransferShipQty { get; set; }
        /// <summary>
        /// Gets or sets the planning worksheet qty.
        /// </summary>
        /// <value>
        /// The planning worksheet qty.
        /// </value>
        public decimal PlanningWorksheetQty { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [stock keeping unit exists].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [stock keeping unit exists]; otherwise, <c>false</c>.
        /// </value>
        public bool StockKeepingUnitExists { get; set; }
        /// <summary>
        /// Gets or sets the manufacturer code.
        /// </summary>
        /// <value>
        /// The manufacturer code.
        /// </value>
        public string ManufacturerCode { get; set; } // Custom
        /// <summary>
        /// Gets or sets the item category code.
        /// </summary>
        /// <value>
        /// The item category code.
        /// </value>
        public string ItemCategoryCode { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is created from non stock item.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is created from non stock item; otherwise, <c>false</c>.
        /// </value>
        public bool IsCreatedFromNonStockItem { get; set; }
        /// <summary>
        /// Gets or sets the product group code.
        /// </summary>
        /// <value>
        /// The product group code.
        /// </value>
        public string ProductGroupCode { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether [substitutes exist].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [substitutes exist]; otherwise, <c>false</c>.
        /// </value>
        public bool SubstitutesExist { get; set; }
        /// <summary>
        /// Gets or sets the qty in transit.
        /// </summary>
        /// <value>
        /// The qty in transit.
        /// </value>
        public decimal QtyInTransit { get; set; }
        /// <summary>
        /// Gets or sets the trans ord receipt qty.
        /// </summary>
        /// <value>
        /// The trans ord receipt qty.
        /// </value>
        public decimal TransOrdReceiptQty { get; set; }
        /// <summary>
        /// Gets or sets the trans ord shipment qty.
        /// </summary>
        /// <value>
        /// The trans ord shipment qty.
        /// </value>
        public decimal TransOrdShipmentQty { get; set; }
        /// <summary>
        /// Gets or sets the qty assigned to ship.
        /// </summary>
        /// <value>
        /// The qty assigned to ship.
        /// </value>
        public decimal QtyAssignedToShip { get; set; }
        /// <summary>
        /// Gets or sets the qty picked.
        /// </summary>
        /// <value>
        /// The qty picked.
        /// </value>
        public decimal QtyPicked { get; set; }
        /// <summary>
        /// Gets or sets the service item group.
        /// </summary>
        /// <value>
        /// The service item group.
        /// </value>
        public string ServiceItemGroup { get; set; }
        /// <summary>
        /// Gets or sets the qty on service order.
        /// </summary>
        /// <value>
        /// The qty on service order.
        /// </value>
        public decimal QtyOnServiceOrder { get; set; }
        /// <summary>
        /// Gets or sets the resource qty on service orders.
        /// </summary>
        /// <value>
        /// The resource qty on service orders.
        /// </value>
        public decimal ResQtyOnServiceOrders { get; set; }
        /// <summary>
        /// Gets or sets the item tracking code.
        /// </summary>
        /// <value>
        /// The item tracking code.
        /// </value>
        public string ItemTrackingCode { get; set; } // Custom
        /// <summary>
        /// Gets or sets the lot nos.
        /// </summary>
        /// <value>
        /// The lot nos.
        /// </value>
        public string LotNos { get; set; } // Custom
        /// <summary>
        /// Gets or sets the expiration calculation.
        /// </summary>
        /// <value>
        /// The expiration calculation.
        /// </value>
        public string ExpirationCalculation { get; set; }
        /// <summary>
        /// Gets or sets the lot no filter.
        /// </summary>
        /// <value>
        /// The lot no filter.
        /// </value>
        public string LotNoFilter { get; set; }
        /// <summary>
        /// Gets or sets the serial no filter.
        /// </summary>
        /// <value>
        /// The serial no filter.
        /// </value>
        public string SerialNoFilter { get; set; }
        /// <summary>
        /// Gets or sets the qty on purchase return.
        /// </summary>
        /// <value>
        /// The qty on purchase return.
        /// </value>
        public decimal QtyOnPurchaseReturn { get; set; }
        /// <summary>
        /// Gets or sets the qty on sales return.
        /// </summary>
        /// <value>
        /// The qty on sales return.
        /// </value>
        public decimal QtyOnSalesReturn { get; set; }
        /// <summary>
        /// Gets or sets the no of substitutes.
        /// </summary>
        /// <value>
        /// The no of substitutes.
        /// </value>
        public int NoOfSubstitutes { get; set; }
        /// <summary>
        /// Gets or sets the warehouse class code.
        /// </summary>
        /// <value>
        /// The warehouse class code.
        /// </value>
        public string WarehouseClassCode { get; set; } // Custom
        /// <summary>
        /// Gets or sets the special equipment code.
        /// </summary>
        /// <value>
        /// The special equipment code.
        /// </value>
        public string SpecialEquipmentCode { get; set; }
        /// <summary>
        /// Gets or sets the put away template code.
        /// </summary>
        /// <value>
        /// The put away template code.
        /// </value>
        public string PutAwayTemplateCode { get; set; }
        /// <summary>
        /// Gets or sets the put away unit of measure code.
        /// </summary>
        /// <value>
        /// The put away unit of measure code.
        /// </value>
        public string PutAwayUnitOfMeasureCode { get; set; }
        /// <summary>
        /// Gets or sets the physical invt counting period code.
        /// </summary>
        /// <value>
        /// The physical invt counting period code.
        /// </value>
        public string PhysInvtCountingPeriodCode { get; set; }
        /// <summary>
        /// Gets or sets the last counting period update.
        /// </summary>
        /// <value>
        /// The last counting period update.
        /// </value>
        public string LastCountingPeriodUpdate { get; set; }
        /// <summary>
        /// Gets or sets the last physical invt date.
        /// </summary>
        /// <value>
        /// The last physical invt date.
        /// </value>
        public DateTime LastPhysInvtDate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [uses cross docking].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [uses cross docking]; otherwise, <c>false</c>.
        /// </value>
        public bool UsesCrossDocking { get; set; }
        /// <summary>
        /// Gets or sets the next counting start date.
        /// </summary>
        /// <value>
        /// The next counting start date.
        /// </value>
        public DateTime NextCountingStartDate { get; set; }
        /// <summary>
        /// Gets or sets the next counting end date.
        /// </summary>
        /// <value>
        /// The next counting end date.
        /// </value>
        public DateTime NextCountingEndDate { get; set; }
        /// <summary>
        /// Gets or sets the identifier code.
        /// </summary>
        /// <value>
        /// The identifier code.
        /// </value>
        public string IdentifierCode { get; set; }
        /// <summary>
        /// Gets or sets the cost regulation percentage.
        /// </summary>
        /// <value>
        /// The cost regulation percentage.
        /// </value>
        public decimal CostRegulationPercentage { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [needs assembly].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [needs assembly]; otherwise, <c>false</c>.
        /// </value>
        public bool NeedsAssembly { get; set; } // Custom
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public int Weight { get; set; } // Custom
        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public string Tag { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the towbar.
        /// </summary>
        /// <value>
        /// The type of the towbar.
        /// </value>
        public string TowbarType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the rear bumper cut.
        /// </summary>
        /// <value>
        /// The type of the rear bumper cut.
        /// </value>
        public int RearBumperCutTypeId { get; set; }
        public RearBumperCutType RearBumperCutType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the warehouse category.
        /// </summary>
        /// <value>
        /// The warehouse category.
        /// </value>
        public string WarehouseCategory { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance has plate cover.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has plate cover; otherwise, <c>false</c>.
        /// </value>
        public bool HasPlateCover { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the estimated assembly time.
        /// </summary>
        /// <value>
        /// The type of the estimated assembly time.
        /// </value>
        public int EstimatedAssemblyTimeTypeId { get; set; }
        public EstimatedAssemblyTimeType EstimatedAssemblyTimeType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the maximum weight over tow ball.
        /// </summary>
        /// <value>
        /// The maximum weight over tow ball.
        /// </value>
        public decimal MaxWeightOverTowBall { get; set; } // Custom
        /// <summary>
        /// Gets or sets the maximum towable weight.
        /// </summary>
        /// <value>
        /// The maximum towable weight.
        /// </value>
        public decimal MaxTowableWeight { get; set; } // Custom
        /// <summary>
        /// Gets or sets the tow value d.
        /// </summary>
        /// <value>
        /// The tow value d.
        /// </value>
        public decimal TowValueD { get; set; } // Custom
        /// <summary>
        /// Gets or sets the homologation.
        /// </summary>
        /// <value>
        /// The homologation.
        /// </value>
        public string Homologation { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the tow ball.
        /// </summary>
        /// <value>
        /// The type of the tow ball.
        /// </value>
        public int TowBallTypeId { get; set; }
        public TowBallType TowBallType { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is new.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is new; otherwise, <c>false</c>.
        /// </value>
        public bool IsNew { get; set; } // Custom
        /// <summary>
        /// Gets or sets the internal volume.
        /// </summary>
        /// <value>
        /// The internal volume.
        /// </value>
        public decimal InternalVolume { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the policy.
        /// </summary>
        /// <value>
        /// The type of the policy.
        /// </value>
        public int PolicyTypeId { get; set; }
        public PolicyType PolicyType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the class.
        /// </summary>
        /// <value>
        /// The type of the class.
        /// </value>
        public int ClassTypeId { get; set; }
        public ClassType ClassType { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether [while stocks last].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [while stocks last]; otherwise, <c>false</c>.
        /// </value>
        public bool WhileStocksLast { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is on request.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is on request; otherwise, <c>false</c>.
        /// </value>
        public bool IsOnRequest { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is in catalog.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is in catalog; otherwise, <c>false</c>.
        /// </value>
        public bool IsInCatalog { get; set; } // Custom
        /// <summary>
        /// Gets or sets the tagss weight.
        /// </summary>
        /// <value>
        /// The tagss weight.
        /// </value>
        public decimal TagssWeight { get; set; } // Custom
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public decimal Width { get; set; } // Custom
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public decimal Height { get; set; } // Custom
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public decimal Length { get; set; } // Custom
        /// <summary>
        /// Gets or sets the inventory01.
        /// </summary>
        /// <value>
        /// The inventory01.
        /// </value>
        public decimal Inventory01 { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [receipt unit of measure double].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [receipt unit of measure double]; otherwise, <c>false</c>.
        /// </value>
        public bool ReceiptUnitOfMeasureDouble { get; set; } // Custom
        /// <summary>
        /// Gets or sets the receipt rounding precision.
        /// </summary>
        /// <value>
        /// The receipt rounding precision.
        /// </value>
        public decimal ReceiptRoundingPrecision { get; set; } // Custom
        /// <summary>
        /// Gets or sets the kit packages.
        /// </summary>
        /// <value>
        /// The kit packages.
        /// </value>
        public int KitPackages { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is kanban.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is kanban; otherwise, <c>false</c>.
        /// </value>
        public bool IsKanban { get; set; } // Custom
        /// <summary>
        /// Gets or sets the tow ball location.
        /// </summary>
        /// <value>
        /// The tow ball location.
        /// </value>
        public string TowBallLocation { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is web product.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is web product; otherwise, <c>false</c>.
        /// </value>
        public bool IsWebProduct { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether [uses main plan].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [uses main plan]; otherwise, <c>false</c>.
        /// </value>
        public bool UsesMainPlan { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the manufacturing category.
        /// </summary>
        /// <value>
        /// The type of the manufacturing category.
        /// </value>
        public int ManufacturingCategoryTypeId { get; set; }
        public ManufacturingCategoryType ManufacturingCategoryType { get; set; } // Custom
        /// <summary>
        /// Gets or sets the shipping agent code.
        /// </summary>
        /// <value>
        /// The shipping agent code.
        /// </value>
        public string ShippingAgentCode { get; set; } // Custom
        /// <summary>
        /// Gets or sets the shipping method code.
        /// </summary>
        /// <value>
        /// The shipping method code.
        /// </value>
        public string ShippingMethodCode { get; set; } // Custom
        /// <summary>
        /// Gets or sets the extended description.
        /// </summary>
        /// <value>
        /// The extended description.
        /// </value>
        public string ExtendedDescription { get; set; }
        /// <summary>
        /// Gets or sets the language model vehicle reference.
        /// </summary>
        /// <value>
        /// The language model vehicle reference.
        /// </value>
        public int LanguageModelVehicleRef { get; set; }
        /// <summary>
        /// Gets or sets the main body.
        /// </summary>
        /// <value>
        /// The main body.
        /// </value>
        public string MainBody { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance is out of stock.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is out of stock; otherwise, <c>false</c>.
        /// </value>
        public bool IsOutOfStock { get; set; } // Custom
        /// <summary>
        /// Gets or sets the type of the typology.
        /// </summary>
        /// <value>
        /// The type of the typology.
        /// </value>
        public int TypologyTypeId { get; set; }
        public TypologyType TypologyType { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether [needs assembly validation].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [needs assembly validation]; otherwise, <c>false</c>.
        /// </value>
        public bool NeedsAssemblyValidation { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance has automatic location.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has automatic location; otherwise, <c>false</c>.
        /// </value>
        public bool HasAutomaticLocation { get; set; } // Custom
        /// <summary>
        /// Gets or sets a value indicating whether this instance has automatic picking.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has automatic picking; otherwise, <c>false</c>.
        /// </value>
        public bool HasAutomaticPicking { get; set; } // Custom
        /// <summary>
        /// Gets or sets the routing no.
        /// </summary>
        /// <value>
        /// The routing no.
        /// </value>
        public string RoutingNo { get; set; } // Custom
        /// <summary>
        /// Gets or sets the production bom no.
        /// </summary>
        /// <value>
        /// The production bom no.
        /// </value>
        public string ProductionBomNo { get; set; } // Custom
        /// <summary>
        /// Gets or sets the single level material cost.
        /// </summary>
        /// <value>
        /// The single level material cost.
        /// </value>
        public decimal SingleLevelMaterialCost { get; set; }
        /// <summary>
        /// Gets or sets the single level capacity cost.
        /// </summary>
        /// <value>
        /// The single level capacity cost.
        /// </value>
        public decimal SingleLevelCapacityCost { get; set; }
        /// <summary>
        /// Gets or sets the single level subcontrd cost.
        /// </summary>
        /// <value>
        /// The single level subcontrd cost.
        /// </value>
        public decimal SingleLevelSubcontrdCost { get; set; }
        /// <summary>
        /// Gets or sets the single level cap ovhd cost.
        /// </summary>
        /// <value>
        /// The single level cap ovhd cost.
        /// </value>
        public decimal SingleLevelCapOvhdCost { get; set; }
        /// <summary>
        /// Gets or sets the single level MFG ovhd cost.
        /// </summary>
        /// <value>
        /// The single level MFG ovhd cost.
        /// </value>
        public decimal SingleLevelMfgOvhdCost { get; set; }
        /// <summary>
        /// Gets or sets the overhead rate.
        /// </summary>
        /// <value>
        /// The overhead rate.
        /// </value>
        public decimal OverheadRate { get; set; }
        /// <summary>
        /// Gets or sets the rolled up subcontracted cost.
        /// </summary>
        /// <value>
        /// The rolled up subcontracted cost.
        /// </value>
        public decimal RolledUpSubcontractedCost { get; set; }
        /// <summary>
        /// Gets or sets the rolled up MFG ovhd cost.
        /// </summary>
        /// <value>
        /// The rolled up MFG ovhd cost.
        /// </value>
        public decimal RolledUpMfgOvhdCost { get; set; }
        /// <summary>
        /// Gets or sets the rolled up cap overhead cost.
        /// </summary>
        /// <value>
        /// The rolled up cap overhead cost.
        /// </value>
        public decimal RolledUpCapOverheadCost { get; set; }
        /// <summary>
        /// Gets or sets the planning issues qty.
        /// </summary>
        /// <value>
        /// The planning issues qty.
        /// </value>
        public decimal PlanningIssuesQty { get; set; }
        /// <summary>
        /// Gets or sets the planning receipt qty.
        /// </summary>
        /// <value>
        /// The planning receipt qty.
        /// </value>
        public decimal PlanningReceiptQty { get; set; }
        /// <summary>
        /// Gets or sets the planned order receipt qty.
        /// </summary>
        /// <value>
        /// The planned order receipt qty.
        /// </value>
        public decimal PlannedOrderReceiptQty { get; set; }
        /// <summary>
        /// Gets or sets the fp order receipt qty.
        /// </summary>
        /// <value>
        /// The fp order receipt qty.
        /// </value>
        public decimal FpOrderReceiptQty { get; set; }
        /// <summary>
        /// Gets or sets the relative order receipt qty.
        /// </summary>
        /// <value>
        /// The relative order receipt qty.
        /// </value>
        public decimal RelOrderReceiptQty { get; set; }
        /// <summary>
        /// Gets or sets the planning release qty.
        /// </summary>
        /// <value>
        /// The planning release qty.
        /// </value>
        public decimal PlanningReleaseQty { get; set; }
        /// <summary>
        /// Gets or sets the planned order release qty.
        /// </summary>
        /// <value>
        /// The planned order release qty.
        /// </value>
        public decimal PlannedOrderReleaseQty { get; set; }
        /// <summary>
        /// Gets or sets the purchase req receipt qty.
        /// </summary>
        /// <value>
        /// The purchase req receipt qty.
        /// </value>
        public decimal PurchaseReqReceiptQty { get; set; }
        /// <summary>
        /// Gets or sets the purchase req release qty.
        /// </summary>
        /// <value>
        /// The purchase req release qty.
        /// </value>
        public decimal PurchaseReqReleaseQty { get; set; }
        /// <summary>
        /// Gets or sets the type of the order tracking policy.
        /// </summary>
        /// <value>
        /// The type of the order tracking policy.
        /// </value>
        public int OrderTrackingPolicyTypeId { get; set; }
        public OrderTrackingPolicyType OrderTrackingPolicyType { get; set; }
        /// <summary>
        /// Gets or sets the production forecast qty base.
        /// </summary>
        /// <value>
        /// The production forecast qty base.
        /// </value>
        public decimal ProductionForecastQtyBase { get; set; }
        /// <summary>
        /// Gets or sets the name of the production forecast.
        /// </summary>
        /// <value>
        /// The name of the production forecast.
        /// </value>
        public string ProductionForecastName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [component forecast].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [component forecast]; otherwise, <c>false</c>.
        /// </value>
        public bool ComponentForecast { get; set; }
        /// <summary>
        /// Gets or sets the qty on product order.
        /// </summary>
        /// <value>
        /// The qty on product order.
        /// </value>
        public decimal QtyOnProdOrder { get; set; }
        /// <summary>
        /// Gets or sets the qty on component lines.
        /// </summary>
        /// <value>
        /// The qty on component lines.
        /// </value>
        public decimal QtyOnComponentLines { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is critical.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is critical; otherwise, <c>false</c>.
        /// </value>
        public bool IsCritical { get; set; }
        /// <summary>
        /// Gets or sets the common item no.
        /// </summary>
        /// <value>
        /// The common item no.
        /// </value>
        public string CommonItemNo { get; set; }

        #endregion
    }
}