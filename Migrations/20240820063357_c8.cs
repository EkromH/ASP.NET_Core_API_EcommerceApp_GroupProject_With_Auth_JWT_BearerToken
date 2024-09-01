using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "86409177-800c-43cd-8620-31a032bb09e0", new DateTime(2024, 8, 20, 6, 33, 56, 187, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "ed48d0e3-21de-42e9-b959-3fc46b8111b0", new DateTime(2024, 8, 20, 6, 33, 56, 187, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethod",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
