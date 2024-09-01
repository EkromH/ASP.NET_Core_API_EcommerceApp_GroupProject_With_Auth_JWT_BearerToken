using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Tags_TagId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TagId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrandId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TagId1",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "8a07eb65-d2b5-4191-bd85-289e5b097906", new DateTime(2024, 8, 21, 5, 24, 26, 899, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "2acbd72d-a817-40d4-99c6-c7bfb49c4a8e", new DateTime(2024, 8, 21, 5, 24, 26, 899, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 11, 24, 26, 899, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 11, 24, 26, 899, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 11, 24, 26, 899, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 11, 24, 26, 899, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 21, 11, 24, 26, 899, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products");

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

            migrationBuilder.AddColumn<int>(
                name: "TagId1",
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
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn", "TagId1" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6487), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn", "TagId1" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6490), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn", "TagId1" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6492), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn", "TagId1" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6495), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "BrandId1", "CategoryId1", "CreatedOn", "TagId1" },
                values: new object[] { null, null, new DateTime(2024, 8, 21, 11, 14, 40, 559, DateTimeKind.Local).AddTicks(6498), null });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId1",
                table: "Products",
                column: "BrandId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId1",
                table: "Products",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TagId1",
                table: "Products",
                column: "TagId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId1",
                table: "Products",
                column: "BrandId1",
                principalTable: "Brands",
                principalColumn: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Tags_TagId1",
                table: "Products",
                column: "TagId1",
                principalTable: "Tags",
                principalColumn: "TagId");
        }
    }
}
