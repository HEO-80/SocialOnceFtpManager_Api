using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace EAProductService.Infrastructure.Persistence.Migrations
{
    public partial class UpdatedProductModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_EstimatedAssemblyTime_EstimatedAssemblyTimeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "EstimatedAssemblyTime");

            migrationBuilder.DropIndex(
                name: "IX_Products_EstimatedAssemblyTimeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EstimatedAssemblyTimeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "EstimatedAssemblyTimeTypeId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EstimatedAssemblyTimeTypes",
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
                    table.PrimaryKey("PK_EstimatedAssemblyTimeTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_EstimatedAssemblyTimeTypeId",
                table: "Products",
                column: "EstimatedAssemblyTimeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_EstimatedAssemblyTimeTypes_EstimatedAssemblyTimeTypeId",
                table: "Products",
                column: "EstimatedAssemblyTimeTypeId",
                principalTable: "EstimatedAssemblyTimeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_EstimatedAssemblyTimeTypes_EstimatedAssemblyTimeTypeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "EstimatedAssemblyTimeTypes");

            migrationBuilder.DropIndex(
                name: "IX_Products_EstimatedAssemblyTimeTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EstimatedAssemblyTimeTypeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "EstimatedAssemblyTimeId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EstimatedAssemblyTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimatedAssemblyTime", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_EstimatedAssemblyTimeId",
                table: "Products",
                column: "EstimatedAssemblyTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_EstimatedAssemblyTime_EstimatedAssemblyTimeId",
                table: "Products",
                column: "EstimatedAssemblyTimeId",
                principalTable: "EstimatedAssemblyTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
