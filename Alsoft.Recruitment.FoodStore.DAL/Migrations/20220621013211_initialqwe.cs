using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    public partial class initialqwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnumerationId = table.Column<int>(type: "int", nullable: false),
                    EnumerationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnumerationId = table.Column<int>(type: "int", nullable: false),
                    EnumerationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercentage = table.Column<double>(type: "float", nullable: false),
                    DiscountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountQuantity = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discount_DiscountType_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StringValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueTypeString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductProperty_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "EnumerationId", "EnumerationName", "ModifiedOn", "TypeId" },
                values: new object[,]
                {
                    { new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"), new DateTime(2022, 6, 21, 3, 32, 11, 53, DateTimeKind.Local).AddTicks(6911), false, null, 1, "DiscountType", null, new Guid("92bd474e-13d6-3831-9536-44eb75ac962a") },
                    { new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"), new DateTime(2022, 6, 21, 3, 32, 11, 55, DateTimeKind.Local).AddTicks(1447), false, null, 2, "DiscountType", null, new Guid("92bd474e-13d6-3831-9536-44eb75ac962a") },
                    { new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"), new DateTime(2022, 6, 21, 3, 32, 11, 55, DateTimeKind.Local).AddTicks(1467), false, null, 3, "DiscountType", null, new Guid("92bd474e-13d6-3831-9536-44eb75ac962a") }
                });

            migrationBuilder.InsertData(
                table: "UnitType",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "EnumerationId", "EnumerationName", "ModifiedOn", "TypeId" },
                values: new object[,]
                {
                    { new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1629), false, null, 3, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1726), false, null, 1, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1743), false, null, 4, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1749), false, null, 5, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(1754), false, null, 2, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") }
                });

            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "CreatedOn", "DateFrom", "DateTo", "Deleted", "DeletedOn", "DiscountPercentage", "DiscountQuantity", "DiscountTypeId", "ModifiedOn", "Name", "TargetProductId" },
                values: new object[,]
                {
                    { new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"), new DateTime(2022, 6, 21, 3, 32, 11, 57, DateTimeKind.Local).AddTicks(3994), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 10.0, null, new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"), null, "Apples are 10% of this week.", null },
                    { new Guid("4a61c3f0-7c36-4b23-95c7-3f2b7de11418"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(1180), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 50.0, 2, new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"), null, "Buy 2 tins of soup and get one roll for half price.", new Guid("6cd1c643-e710-4115-92b1-678925181d7b") },
                    { new Guid("3d1c9901-172c-48ea-8241-978e504b2386"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(1511), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 20.0, 1, new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"), null, "Bread & Milk -20% (unique per product/combination)", null },
                    { new Guid("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(1525), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2099, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 20.0, 1, new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"), null, "Bread & Milk -20% (unique per product/combination)", null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "ModifiedOn", "Name", "Price", "UnitTypeId" },
                values: new object[,]
                {
                    { new Guid("6cd1c643-e710-4115-92b1-678925181d7b"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4360), false, null, null, "Roll", 0.30m, new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9") },
                    { new Guid("598b7145-5444-454d-a619-81ca82f506de"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(3419), false, null, null, "Soup", 0.65m, new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c") },
                    { new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4364), false, null, null, "Full-Cream Milk", 1.60m, new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f") },
                    { new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4370), false, null, null, "Low Fat Milk", 1.35m, new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f") },
                    { new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4374), false, null, null, "Apples", 1.00m, new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9") },
                    { new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"), new DateTime(2022, 6, 21, 3, 32, 11, 56, DateTimeKind.Local).AddTicks(4349), false, null, null, "Bread", 0.80m, new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342") }
                });

            migrationBuilder.InsertData(
                table: "DiscountProduct",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "DiscountId", "ModifiedOn", "ProductId" },
                values: new object[,]
                {
                    { new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2009), false, null, new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"), null, new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab") },
                    { new Guid("4a61c3f0-7c36-4b23-95c7-3f2b7de11418"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2213), false, null, new Guid("4a61c3f0-7c36-4b23-95c7-3f2b7de11418"), null, new Guid("598b7145-5444-454d-a619-81ca82f506de") },
                    { new Guid("cbb02348-6cff-4c75-9c0c-bd2369a11bba"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2219), false, null, new Guid("3d1c9901-172c-48ea-8241-978e504b2386"), null, new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef") },
                    { new Guid("6d2bed64-0e62-46c2-b305-a27fb2c2b795"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2224), false, null, new Guid("3d1c9901-172c-48ea-8241-978e504b2386"), null, new Guid("34f233bb-1ab8-4107-96ab-42c67321745e") },
                    { new Guid("72ff89e3-05f0-4b75-a786-7ef91e6a6bc4"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2228), false, null, new Guid("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"), null, new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c") },
                    { new Guid("231aa719-a4a5-4c00-b159-a2668f3f7dd5"), new DateTime(2022, 6, 21, 3, 32, 11, 63, DateTimeKind.Local).AddTicks(2232), false, null, new Guid("db6dde47-d500-45f5-b1d0-6d4a9a4a6158"), null, new Guid("34f233bb-1ab8-4107-96ab-42c67321745e") }
                });

            migrationBuilder.InsertData(
                table: "ProductProperty",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "ModifiedOn", "Name", "ProductId", "StringValue", "ValueTypeString" },
                values: new object[,]
                {
                    { new Guid("118aece2-2c32-4dac-bd42-7f66e230d9b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Flavour", new Guid("6cd1c643-e710-4115-92b1-678925181d7b"), "Chicken", "String" },
                    { new Guid("6f029c5e-4433-4cd0-ae6a-677be0c1e3e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Flavour", new Guid("598b7145-5444-454d-a619-81ca82f506de"), "Chicken", "String" },
                    { new Guid("e35732bc-520b-492e-9210-7580ffcfc071"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Fat Percentage", new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"), "3,2", "Double" },
                    { new Guid("c5674188-6e70-44f1-9dba-83f7b1c04dfe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Fat Percentage", new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"), "1,5", "Double" },
                    { new Guid("407b5697-ce5f-4b3d-b737-71bcee70b1ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Origin", new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"), "Poland", "String" },
                    { new Guid("19fce08f-5e9c-4d01-9acd-c9a53a8fbd7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Calories", new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"), "251", "Int32" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discount_DiscountTypeId",
                table: "Discount",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProduct_DiscountId",
                table: "DiscountProduct",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UnitTypeId",
                table: "Product",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperty_ProductId",
                table: "ProductProperty",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountProduct");

            migrationBuilder.DropTable(
                name: "ProductProperty");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "UnitType");
        }
    }
}
