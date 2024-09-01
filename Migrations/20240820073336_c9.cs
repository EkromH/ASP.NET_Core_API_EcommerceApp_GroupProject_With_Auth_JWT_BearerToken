using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsDB_R57_Solely.Migrations
{
    /// <inheritdoc />
    public partial class c9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributeId1",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductAttributeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductAttributeId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductAttributeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductAttributeId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Item_ProductName",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Item_ThumbnailImage",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Item_ProductId",
                table: "OrderItems",
                newName: "ProductId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderItems",
                newName: "Item_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "ProductAttributeId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductAttributeId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Item_ProductId",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Item_ProductName",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Item_ThumbnailImage",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    ProductAttributeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.ProductAttributeId);
                });

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
                columns: new[] { "CreatedOn", "ProductAttributeId", "ProductAttributeId1" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4826), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ProductAttributeId", "ProductAttributeId1" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4829), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ProductAttributeId", "ProductAttributeId1" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4832), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ProductAttributeId", "ProductAttributeId1" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4834), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ProductAttributeId", "ProductAttributeId1" },
                values: new object[] { new DateTime(2024, 8, 20, 12, 33, 56, 187, DateTimeKind.Local).AddTicks(4837), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductAttributeId",
                table: "Products",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductAttributeId1",
                table: "Products",
                column: "ProductAttributeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributeId",
                table: "Products",
                column: "ProductAttributeId",
                principalTable: "ProductAttributes",
                principalColumn: "ProductAttributeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributeId1",
                table: "Products",
                column: "ProductAttributeId1",
                principalTable: "ProductAttributes",
                principalColumn: "ProductAttributeId");
        }
    }
}
