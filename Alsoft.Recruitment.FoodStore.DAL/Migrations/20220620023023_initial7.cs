using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscountProduct_Discount_DiscountsId",
                table: "DiscountProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountProduct_Product_ProductsId",
                table: "DiscountProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiscountProduct",
                table: "DiscountProduct");

            migrationBuilder.DropIndex(
                name: "IX_DiscountProduct_ProductsId",
                table: "DiscountProduct");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "DiscountProduct",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "DiscountsId",
                table: "DiscountProduct",
                newName: "DiscountId");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "DiscountProduct",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "DiscountProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DiscountProduct",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "DiscountProduct",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "DiscountProduct",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiscountProduct",
                table: "DiscountProduct",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 291, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.InsertData(
                table: "DiscountProduct",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "DiscountId", "ModifiedOn", "ProductId" },
                values: new object[] { new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"), new DateTime(2022, 6, 20, 4, 30, 23, 291, DateTimeKind.Local).AddTicks(6602), false, null, new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"), null, new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab") });

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 287, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 289, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 289, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 30, 23, 290, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProduct_DiscountId",
                table: "DiscountProduct",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountProduct_Discount_DiscountId",
                table: "DiscountProduct",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiscountProduct_Discount_DiscountId",
                table: "DiscountProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiscountProduct",
                table: "DiscountProduct");

            migrationBuilder.DropIndex(
                name: "IX_DiscountProduct_DiscountId",
                table: "DiscountProduct");

            migrationBuilder.DeleteData(
                table: "DiscountProduct",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DiscountProduct");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "DiscountProduct");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DiscountProduct");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "DiscountProduct");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "DiscountProduct");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "DiscountProduct",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "DiscountId",
                table: "DiscountProduct",
                newName: "DiscountsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiscountProduct",
                table: "DiscountProduct",
                columns: new[] { "DiscountsId", "ProductsId" });

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
        }
    }
}
