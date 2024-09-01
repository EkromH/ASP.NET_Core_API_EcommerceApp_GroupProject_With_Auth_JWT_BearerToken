using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks");

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "27bca556-d24d-402c-8ca6-5376b5cfe41e", new DateTime(2024, 8, 20, 5, 0, 9, 667, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "82846e00-6332-473a-abfd-c9b1c4599759", new DateTime(2024, 8, 20, 5, 0, 9, 667, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "StockId" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 0, 9, 667, DateTimeKind.Local).AddTicks(752), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "StockId" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 0, 9, 667, DateTimeKind.Local).AddTicks(755), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "StockId" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 0, 9, 667, DateTimeKind.Local).AddTicks(757), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "StockId" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 0, 9, 667, DateTimeKind.Local).AddTicks(760), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "StockId" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 0, 9, 667, DateTimeKind.Local).AddTicks(763), null });

            migrationBuilder.CreateIndex(
                name: "IX_Products_StockId",
                table: "Products",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Stocks_StockId",
                table: "Products",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "StockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Stocks_StockId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StockId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "b10fc82d-587e-4797-a436-6afa27b9dc86", new DateTime(2024, 8, 20, 4, 30, 55, 534, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "1e16e765-1b6f-4b02-b9ba-66a28fc7cfdd", new DateTime(2024, 8, 20, 4, 30, 55, 534, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 10, 30, 55, 534, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 10, 30, 55, 534, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 10, 30, 55, 534, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 10, 30, 55, 534, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 10, 30, 55, 534, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
