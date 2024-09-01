using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "f9201efa-8fb9-4525-a4b5-77819b0b3b23", new DateTime(2024, 8, 21, 5, 14, 40, 559, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "4ddb7724-771c-4605-9f2c-8e640b9a7d8b", new DateTime(2024, 8, 21, 5, 14, 40, 559, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId1",
                table: "Products",
                column: "BrandId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId1",
                table: "Products",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId1",
                table: "Products",
                column: "BrandId1",
                principalTable: "Brands",
                principalColumn: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrandId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "c0307b40-9bf7-4783-a359-88e15d5d3e1d", new DateTime(2024, 8, 20, 7, 33, 34, 867, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "5012c06b-011f-4f11-82f0-02e7dff88b39", new DateTime(2024, 8, 20, 7, 33, 34, 867, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 13, 33, 34, 867, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 13, 33, 34, 867, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 13, 33, 34, 867, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 13, 33, 34, 867, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 20, 13, 33, 34, 867, DateTimeKind.Local).AddTicks(8041));
        }
    }
}
