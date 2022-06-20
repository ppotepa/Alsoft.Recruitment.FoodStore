using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscountProduct_Discounts_DiscountsId",
                table: "DiscountProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountProduct_Products_ProductsId",
                table: "DiscountProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_DiscountTypes_DiscountTypeId",
                table: "Discounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProperties_Products_ProductId",
                table: "ProductProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitTypes_UnitTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitTypes",
                table: "UnitTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProperties",
                table: "ProductProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiscountTypes",
                table: "DiscountTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Discounts",
                table: "Discounts");

            migrationBuilder.RenameTable(
                name: "UnitTypes",
                newName: "UnitType");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductProperties",
                newName: "ProductProperty");

            migrationBuilder.RenameTable(
                name: "DiscountTypes",
                newName: "DiscountType");

            migrationBuilder.RenameTable(
                name: "Discounts",
                newName: "Discount");

            migrationBuilder.RenameIndex(
                name: "IX_Products_UnitTypeId",
                table: "Product",
                newName: "IX_Product_UnitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperty",
                newName: "IX_ProductProperty_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Discounts_DiscountTypeId",
                table: "Discount",
                newName: "IX_Discount_DiscountTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitType",
                table: "UnitType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProperty",
                table: "ProductProperty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiscountType",
                table: "DiscountType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Discount",
                table: "Discount",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 268, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 265, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 266, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 266, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 59, 13, 267, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.AddForeignKey(
                name: "FK_Discount_DiscountType_DiscountTypeId",
                table: "Discount",
                column: "DiscountTypeId",
                principalTable: "DiscountType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountProduct_Discount_DiscountsId",
                table: "DiscountProduct",
                column: "DiscountsId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountProduct_Product_ProductsId",
                table: "DiscountProduct",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_UnitType_UnitTypeId",
                table: "Product",
                column: "UnitTypeId",
                principalTable: "UnitType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProperty_Product_ProductId",
                table: "ProductProperty",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discount_DiscountType_DiscountTypeId",
                table: "Discount");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountProduct_Discount_DiscountsId",
                table: "DiscountProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountProduct_Product_ProductsId",
                table: "DiscountProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_UnitType_UnitTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProperty_Product_ProductId",
                table: "ProductProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitType",
                table: "UnitType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProperty",
                table: "ProductProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiscountType",
                table: "DiscountType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Discount",
                table: "Discount");

            migrationBuilder.RenameTable(
                name: "UnitType",
                newName: "UnitTypes");

            migrationBuilder.RenameTable(
                name: "ProductProperty",
                newName: "ProductProperties");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "DiscountType",
                newName: "DiscountTypes");

            migrationBuilder.RenameTable(
                name: "Discount",
                newName: "Discounts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProperty_ProductId",
                table: "ProductProperties",
                newName: "IX_ProductProperties_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UnitTypeId",
                table: "Products",
                newName: "IX_Products_UnitTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Discount_DiscountTypeId",
                table: "Discounts",
                newName: "IX_Discounts_DiscountTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitTypes",
                table: "UnitTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProperties",
                table: "ProductProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiscountTypes",
                table: "DiscountTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Discounts",
                table: "Discounts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "DiscountTypes",
                keyColumn: "Id",
                keyValue: new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 677, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "DiscountTypes",
                keyColumn: "Id",
                keyValue: new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 679, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "DiscountTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 679, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 681, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 680, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 680, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 680, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 680, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 680, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 680, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 679, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 679, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 679, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 679, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 55, 32, 679, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountProduct_Discounts_DiscountsId",
                table: "DiscountProduct",
                column: "DiscountsId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountProduct_Products_ProductsId",
                table: "DiscountProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_DiscountTypes_DiscountTypeId",
                table: "Discounts",
                column: "DiscountTypeId",
                principalTable: "DiscountTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProperties_Products_ProductId",
                table: "ProductProperties",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitTypes_UnitTypeId",
                table: "Products",
                column: "UnitTypeId",
                principalTable: "UnitTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
