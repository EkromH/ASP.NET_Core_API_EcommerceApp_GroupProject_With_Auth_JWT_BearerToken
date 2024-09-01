using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "4ef02c8c-5a44-4631-bc9f-a71c1b1e3487", new DateTime(2024, 8, 15, 4, 0, 31, 836, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "c956fd58-bb1b-4f77-a0c8-9158c64fb3b4", new DateTime(2024, 8, 15, 4, 0, 31, 836, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 0, 31, 836, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 0, 31, 836, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 0, 31, 836, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 0, 31, 836, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 0, 31, 836, DateTimeKind.Local).AddTicks(1266));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "0c02393d-e36a-43da-a34f-fb175ea76e1a", new DateTime(2024, 8, 14, 19, 49, 12, 404, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "63983bf5-e83a-4ca9-9114-e2bee4787c75", new DateTime(2024, 8, 14, 19, 49, 12, 404, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "quantity" },
                values: new object[] { new DateTime(2024, 8, 15, 1, 49, 12, 404, DateTimeKind.Local).AddTicks(5778), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "quantity" },
                values: new object[] { new DateTime(2024, 8, 15, 1, 49, 12, 404, DateTimeKind.Local).AddTicks(5783), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "quantity" },
                values: new object[] { new DateTime(2024, 8, 15, 1, 49, 12, 404, DateTimeKind.Local).AddTicks(5787), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "quantity" },
                values: new object[] { new DateTime(2024, 8, 15, 1, 49, 12, 404, DateTimeKind.Local).AddTicks(5791), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "quantity" },
                values: new object[] { new DateTime(2024, 8, 15, 1, 49, 12, 404, DateTimeKind.Local).AddTicks(5794), 0 });
        }
    }
}
