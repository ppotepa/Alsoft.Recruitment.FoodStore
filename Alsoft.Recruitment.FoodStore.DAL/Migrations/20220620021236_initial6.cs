using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Discount_DiscountId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_DiscountId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "DiscountProduct",
                columns: table => new
                {
                    DiscountsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountProduct", x => new { x.DiscountsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Discount_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 72, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 69, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 70, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 70, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 12, 36, 71, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProduct_ProductsId",
                table: "DiscountProduct",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountProduct");

            migrationBuilder.AddColumn<Guid>(
                name: "DiscountId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 268, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 269, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 269, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 54, 270, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.CreateIndex(
                name: "IX_Product_DiscountId",
                table: "Product",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Discount_DiscountId",
                table: "Product",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
