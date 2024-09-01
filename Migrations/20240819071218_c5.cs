using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "63bddeef-d424-49cc-9ed8-ae37823de7c3", new DateTime(2024, 8, 19, 7, 12, 17, 126, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "99e68aec-1acb-4380-a2bd-50d3160f5af2", new DateTime(2024, 8, 19, 7, 12, 17, 126, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.InsertData(
                table: "DeliveryMethods",
                columns: new[] { "DeliveryMethodId", "DeliveryTime", "Description", "Price", "ShortName", "isActive" },
                values: new object[,]
                {
                    { 1, "1-2 Days", "Fastest delivery time", 120.00m, "RedX", true },
                    { 2, "2-5 Days", "Get it within 5 days", 80.00m, "SA", true },
                    { 3, "5-7 Days", "Slower but cheap", 50.00m, "Shundarban", true },
                    { 4, "1-2 Month", "Free! You get what you pay for", 0.00m, "FREE", true }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 13, 12, 17, 126, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 13, 12, 17, 126, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 13, 12, 17, 126, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 13, 12, 17, 126, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 8, 19, 13, 12, 17, 126, DateTimeKind.Local).AddTicks(4618));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "DeliveryMethodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "DeliveryMethodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "DeliveryMethodId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryMethods",
                keyColumn: "DeliveryMethodId",
                keyValue: 4);

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
    }
}
