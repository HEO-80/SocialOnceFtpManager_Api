using Microsoft.EntityFrameworkCore.Migrations;

namespace EAProductService.Infrastructure.Persistence.Migrations
{
    public partial class UpdatedProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AssemblyPolicyType_AssemblyPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ClassType_ClassTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CostingMethodType_CostingMethodTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FlushingMethodType_FlushingMethodTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ManufacturingCategoryType_ManufacturingCategoryTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ManufacturingPolicyType_ManufacturingPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OrderTrackingPolicyType_OrderTrackingPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PolicyType_PolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PreventNegativeInventoryType_PreventNegativeInventoryTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PriceProfitCalculationType_PriceProfitCalculationTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductType_ProductTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_RearBumperCutType_RearBumperCutTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ReorderingPolicyType_ReorderingPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ReplenishmentSystemType_ReplenishmentSystemTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ReserveType_ReserveTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StockOutWarningType_StockOutWarningTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TowBallType_TowBallTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypologyType_TypologyTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypologyType",
                table: "TypologyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TowBallType",
                table: "TowBallType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockOutWarningType",
                table: "StockOutWarningType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReserveType",
                table: "ReserveType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReplenishmentSystemType",
                table: "ReplenishmentSystemType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReorderingPolicyType",
                table: "ReorderingPolicyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RearBumperCutType",
                table: "RearBumperCutType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceProfitCalculationType",
                table: "PriceProfitCalculationType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PreventNegativeInventoryType",
                table: "PreventNegativeInventoryType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PolicyType",
                table: "PolicyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTrackingPolicyType",
                table: "OrderTrackingPolicyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManufacturingPolicyType",
                table: "ManufacturingPolicyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManufacturingCategoryType",
                table: "ManufacturingCategoryType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlushingMethodType",
                table: "FlushingMethodType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostingMethodType",
                table: "CostingMethodType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassType",
                table: "ClassType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssemblyPolicyType",
                table: "AssemblyPolicyType");

            migrationBuilder.RenameTable(
                name: "TypologyType",
                newName: "TypologyTypes");

            migrationBuilder.RenameTable(
                name: "TowBallType",
                newName: "TowBallTypes");

            migrationBuilder.RenameTable(
                name: "StockOutWarningType",
                newName: "StockOutWarningTypes");

            migrationBuilder.RenameTable(
                name: "ReserveType",
                newName: "ReserveTypes");

            migrationBuilder.RenameTable(
                name: "ReplenishmentSystemType",
                newName: "ReplenishmentSystemTypes");

            migrationBuilder.RenameTable(
                name: "ReorderingPolicyType",
                newName: "ReorderingPolicyTypes");

            migrationBuilder.RenameTable(
                name: "RearBumperCutType",
                newName: "RearBumperCutTypes");

            migrationBuilder.RenameTable(
                name: "ProductType",
                newName: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "PriceProfitCalculationType",
                newName: "PriceProfitCalculationTypes");

            migrationBuilder.RenameTable(
                name: "PreventNegativeInventoryType",
                newName: "PreventNegativeInventoryTypes");

            migrationBuilder.RenameTable(
                name: "PolicyType",
                newName: "PolicyTypes");

            migrationBuilder.RenameTable(
                name: "OrderTrackingPolicyType",
                newName: "OrderTrackingPolicyTypes");

            migrationBuilder.RenameTable(
                name: "ManufacturingPolicyType",
                newName: "ManufacturingPolicyTypes");

            migrationBuilder.RenameTable(
                name: "ManufacturingCategoryType",
                newName: "ManufacturingCategoryTypes");

            migrationBuilder.RenameTable(
                name: "FlushingMethodType",
                newName: "FlushingMethodTypes");

            migrationBuilder.RenameTable(
                name: "CostingMethodType",
                newName: "CostingMethodTypes");

            migrationBuilder.RenameTable(
                name: "ClassType",
                newName: "ClassTypes");

            migrationBuilder.RenameTable(
                name: "AssemblyPolicyType",
                newName: "AssemblyPolicyTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypologyTypes",
                table: "TypologyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TowBallTypes",
                table: "TowBallTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockOutWarningTypes",
                table: "StockOutWarningTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReserveTypes",
                table: "ReserveTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReplenishmentSystemTypes",
                table: "ReplenishmentSystemTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReorderingPolicyTypes",
                table: "ReorderingPolicyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RearBumperCutTypes",
                table: "RearBumperCutTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceProfitCalculationTypes",
                table: "PriceProfitCalculationTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreventNegativeInventoryTypes",
                table: "PreventNegativeInventoryTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PolicyTypes",
                table: "PolicyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTrackingPolicyTypes",
                table: "OrderTrackingPolicyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManufacturingPolicyTypes",
                table: "ManufacturingPolicyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManufacturingCategoryTypes",
                table: "ManufacturingCategoryTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlushingMethodTypes",
                table: "FlushingMethodTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostingMethodTypes",
                table: "CostingMethodTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassTypes",
                table: "ClassTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssemblyPolicyTypes",
                table: "AssemblyPolicyTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AssemblyPolicyTypes_AssemblyPolicyTypeId",
                table: "Products",
                column: "AssemblyPolicyTypeId",
                principalTable: "AssemblyPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ClassTypes_ClassTypeId",
                table: "Products",
                column: "ClassTypeId",
                principalTable: "ClassTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CostingMethodTypes_CostingMethodTypeId",
                table: "Products",
                column: "CostingMethodTypeId",
                principalTable: "CostingMethodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FlushingMethodTypes_FlushingMethodTypeId",
                table: "Products",
                column: "FlushingMethodTypeId",
                principalTable: "FlushingMethodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ManufacturingCategoryTypes_ManufacturingCategoryTypeId",
                table: "Products",
                column: "ManufacturingCategoryTypeId",
                principalTable: "ManufacturingCategoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ManufacturingPolicyTypes_ManufacturingPolicyTypeId",
                table: "Products",
                column: "ManufacturingPolicyTypeId",
                principalTable: "ManufacturingPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderTrackingPolicyTypes_OrderTrackingPolicyTypeId",
                table: "Products",
                column: "OrderTrackingPolicyTypeId",
                principalTable: "OrderTrackingPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PolicyTypes_PolicyTypeId",
                table: "Products",
                column: "PolicyTypeId",
                principalTable: "PolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PreventNegativeInventoryTypes_PreventNegativeInventoryTypeId",
                table: "Products",
                column: "PreventNegativeInventoryTypeId",
                principalTable: "PreventNegativeInventoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PriceProfitCalculationTypes_PriceProfitCalculationTypeId",
                table: "Products",
                column: "PriceProfitCalculationTypeId",
                principalTable: "PriceProfitCalculationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_RearBumperCutTypes_RearBumperCutTypeId",
                table: "Products",
                column: "RearBumperCutTypeId",
                principalTable: "RearBumperCutTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReorderingPolicyTypes_ReorderingPolicyTypeId",
                table: "Products",
                column: "ReorderingPolicyTypeId",
                principalTable: "ReorderingPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReplenishmentSystemTypes_ReplenishmentSystemTypeId",
                table: "Products",
                column: "ReplenishmentSystemTypeId",
                principalTable: "ReplenishmentSystemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReserveTypes_ReserveTypeId",
                table: "Products",
                column: "ReserveTypeId",
                principalTable: "ReserveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StockOutWarningTypes_StockOutWarningTypeId",
                table: "Products",
                column: "StockOutWarningTypeId",
                principalTable: "StockOutWarningTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TowBallTypes_TowBallTypeId",
                table: "Products",
                column: "TowBallTypeId",
                principalTable: "TowBallTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypologyTypes_TypologyTypeId",
                table: "Products",
                column: "TypologyTypeId",
                principalTable: "TypologyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AssemblyPolicyTypes_AssemblyPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ClassTypes_ClassTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CostingMethodTypes_CostingMethodTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FlushingMethodTypes_FlushingMethodTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ManufacturingCategoryTypes_ManufacturingCategoryTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ManufacturingPolicyTypes_ManufacturingPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OrderTrackingPolicyTypes_OrderTrackingPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PolicyTypes_PolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PreventNegativeInventoryTypes_PreventNegativeInventoryTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PriceProfitCalculationTypes_PriceProfitCalculationTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_RearBumperCutTypes_RearBumperCutTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ReorderingPolicyTypes_ReorderingPolicyTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ReplenishmentSystemTypes_ReplenishmentSystemTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ReserveTypes_ReserveTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StockOutWarningTypes_StockOutWarningTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TowBallTypes_TowBallTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypologyTypes_TypologyTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypologyTypes",
                table: "TypologyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TowBallTypes",
                table: "TowBallTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockOutWarningTypes",
                table: "StockOutWarningTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReserveTypes",
                table: "ReserveTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReplenishmentSystemTypes",
                table: "ReplenishmentSystemTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReorderingPolicyTypes",
                table: "ReorderingPolicyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RearBumperCutTypes",
                table: "RearBumperCutTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceProfitCalculationTypes",
                table: "PriceProfitCalculationTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PreventNegativeInventoryTypes",
                table: "PreventNegativeInventoryTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PolicyTypes",
                table: "PolicyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTrackingPolicyTypes",
                table: "OrderTrackingPolicyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManufacturingPolicyTypes",
                table: "ManufacturingPolicyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManufacturingCategoryTypes",
                table: "ManufacturingCategoryTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlushingMethodTypes",
                table: "FlushingMethodTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CostingMethodTypes",
                table: "CostingMethodTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassTypes",
                table: "ClassTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssemblyPolicyTypes",
                table: "AssemblyPolicyTypes");

            migrationBuilder.RenameTable(
                name: "TypologyTypes",
                newName: "TypologyType");

            migrationBuilder.RenameTable(
                name: "TowBallTypes",
                newName: "TowBallType");

            migrationBuilder.RenameTable(
                name: "StockOutWarningTypes",
                newName: "StockOutWarningType");

            migrationBuilder.RenameTable(
                name: "ReserveTypes",
                newName: "ReserveType");

            migrationBuilder.RenameTable(
                name: "ReplenishmentSystemTypes",
                newName: "ReplenishmentSystemType");

            migrationBuilder.RenameTable(
                name: "ReorderingPolicyTypes",
                newName: "ReorderingPolicyType");

            migrationBuilder.RenameTable(
                name: "RearBumperCutTypes",
                newName: "RearBumperCutType");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "ProductType");

            migrationBuilder.RenameTable(
                name: "PriceProfitCalculationTypes",
                newName: "PriceProfitCalculationType");

            migrationBuilder.RenameTable(
                name: "PreventNegativeInventoryTypes",
                newName: "PreventNegativeInventoryType");

            migrationBuilder.RenameTable(
                name: "PolicyTypes",
                newName: "PolicyType");

            migrationBuilder.RenameTable(
                name: "OrderTrackingPolicyTypes",
                newName: "OrderTrackingPolicyType");

            migrationBuilder.RenameTable(
                name: "ManufacturingPolicyTypes",
                newName: "ManufacturingPolicyType");

            migrationBuilder.RenameTable(
                name: "ManufacturingCategoryTypes",
                newName: "ManufacturingCategoryType");

            migrationBuilder.RenameTable(
                name: "FlushingMethodTypes",
                newName: "FlushingMethodType");

            migrationBuilder.RenameTable(
                name: "CostingMethodTypes",
                newName: "CostingMethodType");

            migrationBuilder.RenameTable(
                name: "ClassTypes",
                newName: "ClassType");

            migrationBuilder.RenameTable(
                name: "AssemblyPolicyTypes",
                newName: "AssemblyPolicyType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypologyType",
                table: "TypologyType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TowBallType",
                table: "TowBallType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockOutWarningType",
                table: "StockOutWarningType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReserveType",
                table: "ReserveType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReplenishmentSystemType",
                table: "ReplenishmentSystemType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReorderingPolicyType",
                table: "ReorderingPolicyType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RearBumperCutType",
                table: "RearBumperCutType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceProfitCalculationType",
                table: "PriceProfitCalculationType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreventNegativeInventoryType",
                table: "PreventNegativeInventoryType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PolicyType",
                table: "PolicyType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTrackingPolicyType",
                table: "OrderTrackingPolicyType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManufacturingPolicyType",
                table: "ManufacturingPolicyType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManufacturingCategoryType",
                table: "ManufacturingCategoryType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlushingMethodType",
                table: "FlushingMethodType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CostingMethodType",
                table: "CostingMethodType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassType",
                table: "ClassType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssemblyPolicyType",
                table: "AssemblyPolicyType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AssemblyPolicyType_AssemblyPolicyTypeId",
                table: "Products",
                column: "AssemblyPolicyTypeId",
                principalTable: "AssemblyPolicyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ClassType_ClassTypeId",
                table: "Products",
                column: "ClassTypeId",
                principalTable: "ClassType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CostingMethodType_CostingMethodTypeId",
                table: "Products",
                column: "CostingMethodTypeId",
                principalTable: "CostingMethodType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FlushingMethodType_FlushingMethodTypeId",
                table: "Products",
                column: "FlushingMethodTypeId",
                principalTable: "FlushingMethodType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ManufacturingCategoryType_ManufacturingCategoryTypeId",
                table: "Products",
                column: "ManufacturingCategoryTypeId",
                principalTable: "ManufacturingCategoryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ManufacturingPolicyType_ManufacturingPolicyTypeId",
                table: "Products",
                column: "ManufacturingPolicyTypeId",
                principalTable: "ManufacturingPolicyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderTrackingPolicyType_OrderTrackingPolicyTypeId",
                table: "Products",
                column: "OrderTrackingPolicyTypeId",
                principalTable: "OrderTrackingPolicyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PolicyType_PolicyTypeId",
                table: "Products",
                column: "PolicyTypeId",
                principalTable: "PolicyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PreventNegativeInventoryType_PreventNegativeInventoryTypeId",
                table: "Products",
                column: "PreventNegativeInventoryTypeId",
                principalTable: "PreventNegativeInventoryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PriceProfitCalculationType_PriceProfitCalculationTypeId",
                table: "Products",
                column: "PriceProfitCalculationTypeId",
                principalTable: "PriceProfitCalculationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductType_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_RearBumperCutType_RearBumperCutTypeId",
                table: "Products",
                column: "RearBumperCutTypeId",
                principalTable: "RearBumperCutType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReorderingPolicyType_ReorderingPolicyTypeId",
                table: "Products",
                column: "ReorderingPolicyTypeId",
                principalTable: "ReorderingPolicyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReplenishmentSystemType_ReplenishmentSystemTypeId",
                table: "Products",
                column: "ReplenishmentSystemTypeId",
                principalTable: "ReplenishmentSystemType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReserveType_ReserveTypeId",
                table: "Products",
                column: "ReserveTypeId",
                principalTable: "ReserveType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StockOutWarningType_StockOutWarningTypeId",
                table: "Products",
                column: "StockOutWarningTypeId",
                principalTable: "StockOutWarningType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TowBallType_TowBallTypeId",
                table: "Products",
                column: "TowBallTypeId",
                principalTable: "TowBallType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypologyType_TypologyTypeId",
                table: "Products",
                column: "TypologyTypeId",
                principalTable: "TypologyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
