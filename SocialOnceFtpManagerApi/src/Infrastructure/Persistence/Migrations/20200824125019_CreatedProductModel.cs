using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EAProductService.Infrastructure.Persistence.Migrations
{
    public partial class CreatedProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssemblyPolicyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssemblyPolicyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostingMethodType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostingMethodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstimatedAssemblyTime",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimatedAssemblyTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlushingMethodType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlushingMethodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingCategoryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingCategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingPolicyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingPolicyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTrackingPolicyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTrackingPolicyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreventNegativeInventoryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreventNegativeInventoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceProfitCalculationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceProfitCalculationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RearBumperCutType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RearBumperCutType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReorderingPolicyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReorderingPolicyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReplenishmentSystemType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplenishmentSystemType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReserveType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockOutWarningType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockOutWarningType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TowBallType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowBallType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypologyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypologyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    No = table.Column<string>(nullable: true),
                    No2 = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SearchDescription = table.Column<string>(nullable: true),
                    Description2 = table.Column<string>(nullable: true),
                    IsAssemblyBom = table.Column<bool>(nullable: false),
                    BaseUnitOfMeasure = table.Column<string>(nullable: true),
                    PriceUnitConversion = table.Column<int>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: true),
                    InventoryPostingGroup = table.Column<string>(nullable: true),
                    ShelfNo = table.Column<string>(nullable: true),
                    ItemDiscGroup = table.Column<string>(nullable: true),
                    AllowsInvoiceDiscount = table.Column<bool>(nullable: false),
                    StatisticsGroup = table.Column<int>(nullable: false),
                    CommissionGroup = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    PriceProfitCalculationTypeId = table.Column<int>(nullable: true),
                    ProfitPercentage = table.Column<decimal>(nullable: false),
                    CostingMethodTypeId = table.Column<int>(nullable: true),
                    UnitCost = table.Column<decimal>(nullable: false),
                    StandardCost = table.Column<decimal>(nullable: false),
                    LastDirectCost = table.Column<decimal>(nullable: false),
                    IndirectCostPercentage = table.Column<decimal>(nullable: false),
                    IsCostAdjusted = table.Column<bool>(nullable: false),
                    AllowOnlineAdjustment = table.Column<bool>(nullable: false),
                    VendorNo = table.Column<string>(nullable: true),
                    VendorItemNo = table.Column<string>(nullable: true),
                    LeadTimeCalculation = table.Column<string>(nullable: true),
                    ReorderPoint = table.Column<decimal>(nullable: false),
                    MaximumInventory = table.Column<decimal>(nullable: false),
                    ReorderQuantity = table.Column<decimal>(nullable: false),
                    AlternativeItemNo = table.Column<string>(nullable: true),
                    UnitListPrice = table.Column<decimal>(nullable: false),
                    DutyDuePercentage = table.Column<decimal>(nullable: false),
                    DutyCode = table.Column<string>(nullable: true),
                    GrossWeight = table.Column<decimal>(nullable: false),
                    NetWeight = table.Column<decimal>(nullable: false),
                    UnitsPerParcel = table.Column<decimal>(nullable: false),
                    UnitVolume = table.Column<decimal>(nullable: false),
                    Durability = table.Column<string>(nullable: true),
                    FreightType = table.Column<string>(nullable: true),
                    TariffNo = table.Column<string>(nullable: true),
                    DutyUnitConversion = table.Column<decimal>(nullable: false),
                    CountryRegionPurchasedCode = table.Column<string>(nullable: true),
                    BudgetQuantity = table.Column<decimal>(nullable: false),
                    BudgetedAmount = table.Column<decimal>(nullable: false),
                    BudgetProfit = table.Column<decimal>(nullable: false),
                    HasComments = table.Column<bool>(nullable: false),
                    IsBlocked = table.Column<bool>(nullable: false),
                    CostIsPostedToGl = table.Column<bool>(nullable: false),
                    LastDateModified = table.Column<string>(nullable: true),
                    LastTimeModified = table.Column<string>(nullable: true),
                    DateFilter = table.Column<string>(nullable: true),
                    GlobalDimension1Filter = table.Column<string>(nullable: true),
                    GlobalDimension2Filter = table.Column<string>(nullable: true),
                    LocationFilter = table.Column<string>(nullable: true),
                    Inventory = table.Column<decimal>(nullable: false),
                    NetInvoicedQty = table.Column<decimal>(nullable: false),
                    NetChange = table.Column<decimal>(nullable: false),
                    PurchasesQty = table.Column<decimal>(nullable: false),
                    SalesQty = table.Column<decimal>(nullable: false),
                    PositiveAdjustmentQty = table.Column<decimal>(nullable: false),
                    NegativeAdjustmentQty = table.Column<decimal>(nullable: false),
                    PurchasesLcy = table.Column<decimal>(nullable: false),
                    SalesLcy = table.Column<decimal>(nullable: false),
                    PositiveAdjustmentLcy = table.Column<decimal>(nullable: false),
                    NegativeAdjustmentLcy = table.Column<decimal>(nullable: false),
                    CogsLcy = table.Column<decimal>(nullable: false),
                    QtyOnPurchaseOrder = table.Column<decimal>(nullable: false),
                    QtyOnSalesOrder = table.Column<decimal>(nullable: false),
                    PriceIncludesVat = table.Column<bool>(nullable: false),
                    DropShipmentFilter = table.Column<bool>(nullable: false),
                    VatBusPostingGrPrice = table.Column<string>(nullable: true),
                    GenProdPostingGroup = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    TransferredQty = table.Column<decimal>(nullable: false),
                    TransferredLcy = table.Column<decimal>(nullable: false),
                    CountryRegionOfOriginCode = table.Column<string>(nullable: true),
                    AutomaticExtTexts = table.Column<bool>(nullable: false),
                    NoSeries = table.Column<string>(nullable: true),
                    TaxGroupCode = table.Column<string>(nullable: true),
                    VatProdPostingGroup = table.Column<string>(nullable: true),
                    ReserveTypeId = table.Column<int>(nullable: true),
                    ReservedQtyOnInventory = table.Column<decimal>(nullable: false),
                    ReservedQtyOnPurchasesOrders = table.Column<decimal>(nullable: false),
                    ReservedQtyOnSalesOrders = table.Column<decimal>(nullable: false),
                    GlobalDimension1Code = table.Column<string>(nullable: true),
                    GlobalDimension2Code = table.Column<string>(nullable: true),
                    ResQtyOnOutboundTransfer = table.Column<decimal>(nullable: false),
                    ResQtyOnInboundTransfer = table.Column<decimal>(nullable: false),
                    ResQtyOnSalesReturns = table.Column<decimal>(nullable: false),
                    ResQtyOnPurchasesReturns = table.Column<decimal>(nullable: false),
                    StockOutWarningTypeId = table.Column<int>(nullable: true),
                    PreventNegativeInventoryTypeId = table.Column<int>(nullable: true),
                    CostOfOpenProductionOrders = table.Column<decimal>(nullable: false),
                    ApplicationWkshUserId = table.Column<string>(nullable: true),
                    AssemblyPolicyTypeId = table.Column<int>(nullable: true),
                    ResQtyOnAssemblyOrder = table.Column<decimal>(nullable: false),
                    ResQtyOnAsmComp = table.Column<decimal>(nullable: false),
                    QtyOnAssemblyOrder = table.Column<decimal>(nullable: false),
                    QtyOnAsmComponent = table.Column<decimal>(nullable: false),
                    QtyOnJobOrder = table.Column<decimal>(nullable: false),
                    ResQtyOnJobOrder = table.Column<decimal>(nullable: false),
                    Gtin = table.Column<string>(nullable: true),
                    DefaultDeferralTemplateCode = table.Column<string>(nullable: true),
                    LowLevelCode = table.Column<int>(nullable: false),
                    LotSize = table.Column<decimal>(nullable: false),
                    SerialNos = table.Column<string>(nullable: true),
                    LastUnitCostCalcDate = table.Column<string>(nullable: true),
                    RolledUpMaterialCost = table.Column<decimal>(nullable: false),
                    RolledUpCapacityCost = table.Column<decimal>(nullable: false),
                    ScrapPercentage = table.Column<decimal>(nullable: false),
                    InventoryValueZero = table.Column<bool>(nullable: false),
                    DiscreteOrderQuantity = table.Column<int>(nullable: false),
                    MinimumOrderQuantity = table.Column<decimal>(nullable: false),
                    MaximumOrderQuantity = table.Column<decimal>(nullable: false),
                    SafetyStockQuantity = table.Column<decimal>(nullable: false),
                    OrderMultiple = table.Column<decimal>(nullable: false),
                    SafetyLeadTime = table.Column<string>(nullable: true),
                    FlushingMethodTypeId = table.Column<int>(nullable: true),
                    ReplenishmentSystemTypeId = table.Column<int>(nullable: true),
                    ScheduledReceiptQty = table.Column<decimal>(nullable: false),
                    ScheduledNeedQty = table.Column<decimal>(nullable: false),
                    RoundingPrecision = table.Column<decimal>(nullable: false),
                    BinFilter = table.Column<string>(nullable: true),
                    VariantFilter = table.Column<string>(nullable: true),
                    SalesUnitOfMeasure = table.Column<string>(nullable: true),
                    PurchaseUnitOfMeasure = table.Column<string>(nullable: true),
                    TimeBucket = table.Column<string>(nullable: true),
                    ReservedQtyOnProdOrder = table.Column<decimal>(nullable: false),
                    ResQtyOnProdOrderComp = table.Column<decimal>(nullable: false),
                    ResQtyOnReqLine = table.Column<decimal>(nullable: false),
                    ReorderingPolicyTypeId = table.Column<int>(nullable: true),
                    IncludesInventory = table.Column<bool>(nullable: false),
                    ManufacturingPolicyTypeId = table.Column<int>(nullable: true),
                    ReschedulingPeriod = table.Column<string>(nullable: true),
                    LotAccumulationPeriod = table.Column<string>(nullable: true),
                    DampenerPeriod = table.Column<string>(nullable: true),
                    DampenerQuantity = table.Column<decimal>(nullable: false),
                    OverflowLevel = table.Column<decimal>(nullable: false),
                    PlanningTransferShipQty = table.Column<decimal>(nullable: false),
                    PlanningWorksheetQty = table.Column<decimal>(nullable: false),
                    StockKeepingUnitExists = table.Column<bool>(nullable: false),
                    ManufacturerCode = table.Column<string>(nullable: true),
                    ItemCategoryCode = table.Column<string>(nullable: true),
                    IsCreatedFromNonStockItem = table.Column<bool>(nullable: false),
                    ProductGroupCode = table.Column<string>(nullable: true),
                    SubstitutesExist = table.Column<bool>(nullable: false),
                    QtyInTransit = table.Column<decimal>(nullable: false),
                    TransOrdReceiptQty = table.Column<decimal>(nullable: false),
                    TransOrdShipmentQty = table.Column<decimal>(nullable: false),
                    QtyAssignedToShip = table.Column<decimal>(nullable: false),
                    QtyPicked = table.Column<decimal>(nullable: false),
                    ServiceItemGroup = table.Column<string>(nullable: true),
                    QtyOnServiceOrder = table.Column<decimal>(nullable: false),
                    ResQtyOnServiceOrders = table.Column<decimal>(nullable: false),
                    ItemTrackingCode = table.Column<string>(nullable: true),
                    LotNos = table.Column<string>(nullable: true),
                    ExpirationCalculation = table.Column<string>(nullable: true),
                    LotNoFilter = table.Column<string>(nullable: true),
                    SerialNoFilter = table.Column<string>(nullable: true),
                    QtyOnPurchaseReturn = table.Column<decimal>(nullable: false),
                    QtyOnSalesReturn = table.Column<decimal>(nullable: false),
                    NoOfSubstitutes = table.Column<int>(nullable: false),
                    WarehouseClassCode = table.Column<string>(nullable: true),
                    SpecialEquipmentCode = table.Column<string>(nullable: true),
                    PutAwayTemplateCode = table.Column<string>(nullable: true),
                    PutAwayUnitOfMeasureCode = table.Column<string>(nullable: true),
                    PhysInvtCountingPeriodCode = table.Column<string>(nullable: true),
                    LastCountingPeriodUpdate = table.Column<string>(nullable: true),
                    LastPhysInvtDate = table.Column<string>(nullable: true),
                    UsesCrossDocking = table.Column<bool>(nullable: false),
                    NextCountingStartDate = table.Column<string>(nullable: true),
                    NextCountingEndDate = table.Column<string>(nullable: true),
                    IdentifierCode = table.Column<string>(nullable: true),
                    CostRegulationPercentage = table.Column<decimal>(nullable: false),
                    NeedsAssembly = table.Column<bool>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    TowbarType = table.Column<string>(nullable: true),
                    RearBumperCutTypeId = table.Column<int>(nullable: true),
                    WarehouseCategory = table.Column<string>(nullable: true),
                    HasPlateCover = table.Column<bool>(nullable: false),
                    EstimatedAssemblyTimeId = table.Column<int>(nullable: true),
                    MaxWeightOverTowBall = table.Column<decimal>(nullable: false),
                    MaxTowableWeight = table.Column<decimal>(nullable: false),
                    TowValueD = table.Column<decimal>(nullable: false),
                    Homologation = table.Column<string>(nullable: true),
                    TowBallTypeId = table.Column<int>(nullable: true),
                    IsNew = table.Column<bool>(nullable: false),
                    InternalVolume = table.Column<decimal>(nullable: false),
                    PolicyTypeId = table.Column<int>(nullable: true),
                    ClassTypeId = table.Column<int>(nullable: true),
                    WhileStocksLast = table.Column<bool>(nullable: false),
                    IsOnRequest = table.Column<bool>(nullable: false),
                    IsInCatalog = table.Column<bool>(nullable: false),
                    TagssWeight = table.Column<decimal>(nullable: false),
                    Width = table.Column<decimal>(nullable: false),
                    Height = table.Column<decimal>(nullable: false),
                    Length = table.Column<decimal>(nullable: false),
                    Inventory01 = table.Column<decimal>(nullable: false),
                    ReceiptUnitOfMeasureDouble = table.Column<bool>(nullable: false),
                    ReceiptRoundingPrecision = table.Column<decimal>(nullable: false),
                    KitPackages = table.Column<int>(nullable: false),
                    IsKanban = table.Column<bool>(nullable: false),
                    TowBallLocation = table.Column<string>(nullable: true),
                    IsWebProduct = table.Column<bool>(nullable: false),
                    UsesMainPlan = table.Column<bool>(nullable: false),
                    ManufacturingCategoryTypeId = table.Column<int>(nullable: true),
                    ShippingAgentCode = table.Column<string>(nullable: true),
                    ShippingMethodCode = table.Column<string>(nullable: true),
                    ExtendedDescription = table.Column<string>(nullable: true),
                    LanguageModelVehicleRef = table.Column<int>(nullable: false),
                    MainBody = table.Column<string>(nullable: true),
                    IsOutOfStock = table.Column<bool>(nullable: false),
                    TypologyTypeId = table.Column<int>(nullable: true),
                    NeedsAssemblyValidation = table.Column<bool>(nullable: false),
                    HasAutomaticLocation = table.Column<bool>(nullable: false),
                    HasAutomaticPicking = table.Column<bool>(nullable: false),
                    RoutingNo = table.Column<string>(nullable: true),
                    ProductionBomNo = table.Column<string>(nullable: true),
                    SingleLevelMaterialCost = table.Column<decimal>(nullable: false),
                    SingleLevelCapacityCost = table.Column<decimal>(nullable: false),
                    SingleLevelSubcontrdCost = table.Column<decimal>(nullable: false),
                    SingleLevelCapOvhdCost = table.Column<decimal>(nullable: false),
                    SingleLevelMfgOvhdCost = table.Column<decimal>(nullable: false),
                    OverheadRate = table.Column<decimal>(nullable: false),
                    RolledUpSubcontractedCost = table.Column<decimal>(nullable: false),
                    RolledUpMfgOvhdCost = table.Column<decimal>(nullable: false),
                    RolledUpCapOverheadCost = table.Column<decimal>(nullable: false),
                    PlanningIssuesQty = table.Column<decimal>(nullable: false),
                    PlanningReceiptQty = table.Column<decimal>(nullable: false),
                    PlannedOrderReceiptQty = table.Column<decimal>(nullable: false),
                    FpOrderReceiptQty = table.Column<decimal>(nullable: false),
                    RelOrderReceiptQty = table.Column<decimal>(nullable: false),
                    PlanningReleaseQty = table.Column<decimal>(nullable: false),
                    PlannedOrderReleaseQty = table.Column<decimal>(nullable: false),
                    PurchaseReqReceiptQty = table.Column<decimal>(nullable: false),
                    PurchaseReqReleaseQty = table.Column<decimal>(nullable: false),
                    OrderTrackingPolicyTypeId = table.Column<int>(nullable: true),
                    ProductionForecastQtyBase = table.Column<decimal>(nullable: false),
                    ProductionForecastName = table.Column<string>(nullable: true),
                    ComponentForecast = table.Column<bool>(nullable: false),
                    QtyOnProdOrder = table.Column<decimal>(nullable: false),
                    QtyOnComponentLines = table.Column<decimal>(nullable: false),
                    IsCritical = table.Column<bool>(nullable: false),
                    CommonItemNo = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Done = table.Column<bool>(nullable: false),
                    Reminder = table.Column<DateTime>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    ListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AssemblyPolicyType_AssemblyPolicyTypeId",
                        column: x => x.AssemblyPolicyTypeId,
                        principalTable: "AssemblyPolicyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ClassType_ClassTypeId",
                        column: x => x.ClassTypeId,
                        principalTable: "ClassType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_CostingMethodType_CostingMethodTypeId",
                        column: x => x.CostingMethodTypeId,
                        principalTable: "CostingMethodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_EstimatedAssemblyTime_EstimatedAssemblyTimeId",
                        column: x => x.EstimatedAssemblyTimeId,
                        principalTable: "EstimatedAssemblyTime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_FlushingMethodType_FlushingMethodTypeId",
                        column: x => x.FlushingMethodTypeId,
                        principalTable: "FlushingMethodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TodoLists_ListId",
                        column: x => x.ListId,
                        principalTable: "TodoLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ManufacturingCategoryType_ManufacturingCategoryTypeId",
                        column: x => x.ManufacturingCategoryTypeId,
                        principalTable: "ManufacturingCategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ManufacturingPolicyType_ManufacturingPolicyTypeId",
                        column: x => x.ManufacturingPolicyTypeId,
                        principalTable: "ManufacturingPolicyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_OrderTrackingPolicyType_OrderTrackingPolicyTypeId",
                        column: x => x.OrderTrackingPolicyTypeId,
                        principalTable: "OrderTrackingPolicyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_PolicyType_PolicyTypeId",
                        column: x => x.PolicyTypeId,
                        principalTable: "PolicyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_PreventNegativeInventoryType_PreventNegativeInventoryTypeId",
                        column: x => x.PreventNegativeInventoryTypeId,
                        principalTable: "PreventNegativeInventoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_PriceProfitCalculationType_PriceProfitCalculationTypeId",
                        column: x => x.PriceProfitCalculationTypeId,
                        principalTable: "PriceProfitCalculationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_RearBumperCutType_RearBumperCutTypeId",
                        column: x => x.RearBumperCutTypeId,
                        principalTable: "RearBumperCutType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ReorderingPolicyType_ReorderingPolicyTypeId",
                        column: x => x.ReorderingPolicyTypeId,
                        principalTable: "ReorderingPolicyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ReplenishmentSystemType_ReplenishmentSystemTypeId",
                        column: x => x.ReplenishmentSystemTypeId,
                        principalTable: "ReplenishmentSystemType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ReserveType_ReserveTypeId",
                        column: x => x.ReserveTypeId,
                        principalTable: "ReserveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_StockOutWarningType_StockOutWarningTypeId",
                        column: x => x.StockOutWarningTypeId,
                        principalTable: "StockOutWarningType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TowBallType_TowBallTypeId",
                        column: x => x.TowBallTypeId,
                        principalTable: "TowBallType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TypologyType_TypologyTypeId",
                        column: x => x.TypologyTypeId,
                        principalTable: "TypologyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AssemblyPolicyTypeId",
                table: "Products",
                column: "AssemblyPolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClassTypeId",
                table: "Products",
                column: "ClassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CostingMethodTypeId",
                table: "Products",
                column: "CostingMethodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EstimatedAssemblyTimeId",
                table: "Products",
                column: "EstimatedAssemblyTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FlushingMethodTypeId",
                table: "Products",
                column: "FlushingMethodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ListId",
                table: "Products",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturingCategoryTypeId",
                table: "Products",
                column: "ManufacturingCategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturingPolicyTypeId",
                table: "Products",
                column: "ManufacturingPolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderTrackingPolicyTypeId",
                table: "Products",
                column: "OrderTrackingPolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PolicyTypeId",
                table: "Products",
                column: "PolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PreventNegativeInventoryTypeId",
                table: "Products",
                column: "PreventNegativeInventoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PriceProfitCalculationTypeId",
                table: "Products",
                column: "PriceProfitCalculationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RearBumperCutTypeId",
                table: "Products",
                column: "RearBumperCutTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ReorderingPolicyTypeId",
                table: "Products",
                column: "ReorderingPolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ReplenishmentSystemTypeId",
                table: "Products",
                column: "ReplenishmentSystemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ReserveTypeId",
                table: "Products",
                column: "ReserveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StockOutWarningTypeId",
                table: "Products",
                column: "StockOutWarningTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TowBallTypeId",
                table: "Products",
                column: "TowBallTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypologyTypeId",
                table: "Products",
                column: "TypologyTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AssemblyPolicyType");

            migrationBuilder.DropTable(
                name: "ClassType");

            migrationBuilder.DropTable(
                name: "CostingMethodType");

            migrationBuilder.DropTable(
                name: "EstimatedAssemblyTime");

            migrationBuilder.DropTable(
                name: "FlushingMethodType");

            migrationBuilder.DropTable(
                name: "ManufacturingCategoryType");

            migrationBuilder.DropTable(
                name: "ManufacturingPolicyType");

            migrationBuilder.DropTable(
                name: "OrderTrackingPolicyType");

            migrationBuilder.DropTable(
                name: "PolicyType");

            migrationBuilder.DropTable(
                name: "PreventNegativeInventoryType");

            migrationBuilder.DropTable(
                name: "PriceProfitCalculationType");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "RearBumperCutType");

            migrationBuilder.DropTable(
                name: "ReorderingPolicyType");

            migrationBuilder.DropTable(
                name: "ReplenishmentSystemType");

            migrationBuilder.DropTable(
                name: "ReserveType");

            migrationBuilder.DropTable(
                name: "StockOutWarningType");

            migrationBuilder.DropTable(
                name: "TowBallType");

            migrationBuilder.DropTable(
                name: "TypologyType");
        }
    }
}
