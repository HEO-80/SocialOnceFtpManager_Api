using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EAProductService.Infrastructure.Persistence.Migrations
{
    public partial class UpdatedProductRelationsAndDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Products_EstimatedAssemblyTimeTypes_EstimatedAssemblyTimeTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_FlushingMethodTypes_FlushingMethodTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TodoLists_ListId",
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

            migrationBuilder.DropIndex(
                name: "IX_Products_ListId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Done",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastTimeModified",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ListId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Reminder",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "TypologyTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TowBallTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StockOutWarningTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReserveTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReplenishmentSystemTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReorderingPolicyTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RearBumperCutTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PriceProfitCalculationTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PreventNegativeInventoryTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PolicyTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderTrackingPolicyTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCountingStartDate",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NextCountingEndDate",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturingPolicyTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturingCategoryTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUnitCostCalcDate",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastPhysInvtDate",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastDateModified",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FlushingMethodTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EstimatedAssemblyTimeTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFilter",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CostingMethodTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssemblyPolicyTypeId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AssemblyPolicyTypes_AssemblyPolicyTypeId",
                table: "Products",
                column: "AssemblyPolicyTypeId",
                principalTable: "AssemblyPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ClassTypes_ClassTypeId",
                table: "Products",
                column: "ClassTypeId",
                principalTable: "ClassTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CostingMethodTypes_CostingMethodTypeId",
                table: "Products",
                column: "CostingMethodTypeId",
                principalTable: "CostingMethodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_EstimatedAssemblyTimeTypes_EstimatedAssemblyTimeTypeId",
                table: "Products",
                column: "EstimatedAssemblyTimeTypeId",
                principalTable: "EstimatedAssemblyTimeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_FlushingMethodTypes_FlushingMethodTypeId",
                table: "Products",
                column: "FlushingMethodTypeId",
                principalTable: "FlushingMethodTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ManufacturingCategoryTypes_ManufacturingCategoryTypeId",
                table: "Products",
                column: "ManufacturingCategoryTypeId",
                principalTable: "ManufacturingCategoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ManufacturingPolicyTypes_ManufacturingPolicyTypeId",
                table: "Products",
                column: "ManufacturingPolicyTypeId",
                principalTable: "ManufacturingPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderTrackingPolicyTypes_OrderTrackingPolicyTypeId",
                table: "Products",
                column: "OrderTrackingPolicyTypeId",
                principalTable: "OrderTrackingPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PolicyTypes_PolicyTypeId",
                table: "Products",
                column: "PolicyTypeId",
                principalTable: "PolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PreventNegativeInventoryTypes_PreventNegativeInventoryTypeId",
                table: "Products",
                column: "PreventNegativeInventoryTypeId",
                principalTable: "PreventNegativeInventoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PriceProfitCalculationTypes_PriceProfitCalculationTypeId",
                table: "Products",
                column: "PriceProfitCalculationTypeId",
                principalTable: "PriceProfitCalculationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_RearBumperCutTypes_RearBumperCutTypeId",
                table: "Products",
                column: "RearBumperCutTypeId",
                principalTable: "RearBumperCutTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReorderingPolicyTypes_ReorderingPolicyTypeId",
                table: "Products",
                column: "ReorderingPolicyTypeId",
                principalTable: "ReorderingPolicyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReplenishmentSystemTypes_ReplenishmentSystemTypeId",
                table: "Products",
                column: "ReplenishmentSystemTypeId",
                principalTable: "ReplenishmentSystemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ReserveTypes_ReserveTypeId",
                table: "Products",
                column: "ReserveTypeId",
                principalTable: "ReserveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StockOutWarningTypes_StockOutWarningTypeId",
                table: "Products",
                column: "StockOutWarningTypeId",
                principalTable: "StockOutWarningTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TowBallTypes_TowBallTypeId",
                table: "Products",
                column: "TowBallTypeId",
                principalTable: "TowBallTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypologyTypes_TypologyTypeId",
                table: "Products",
                column: "TypologyTypeId",
                principalTable: "TypologyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_Products_EstimatedAssemblyTimeTypes_EstimatedAssemblyTimeTypeId",
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

            migrationBuilder.AlterColumn<int>(
                name: "TypologyTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TowBallTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StockOutWarningTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReserveTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReplenishmentSystemTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReorderingPolicyTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "RearBumperCutTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PriceProfitCalculationTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PreventNegativeInventoryTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PolicyTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OrderTrackingPolicyTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NextCountingStartDate",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "NextCountingEndDate",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturingPolicyTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturingCategoryTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LastUnitCostCalcDate",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "LastPhysInvtDate",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "LastDateModified",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "FlushingMethodTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EstimatedAssemblyTimeTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "DateFilter",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "CostingMethodTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClassTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AssemblyPolicyTypeId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastTimeModified",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Reminder",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ListId",
                table: "Products",
                column: "ListId");

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
                name: "FK_Products_EstimatedAssemblyTimeTypes_EstimatedAssemblyTimeTypeId",
                table: "Products",
                column: "EstimatedAssemblyTimeTypeId",
                principalTable: "EstimatedAssemblyTimeTypes",
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
                name: "FK_Products_TodoLists_ListId",
                table: "Products",
                column: "ListId",
                principalTable: "TodoLists",
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
    }
}
