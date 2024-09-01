using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "484f1051-348a-4e4b-83f5-070c272ebf53", new DateTime(2024, 8, 15, 4, 48, 50, 976, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "25f16878-b2c6-4d23-8b46-7f35bf622721", new DateTime(2024, 8, 15, 4, 48, 50, 976, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 48, 50, 976, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 48, 50, 976, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 48, 50, 976, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 48, 50, 976, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 15, 10, 48, 50, 976, DateTimeKind.Local).AddTicks(5678));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ContactNo",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
