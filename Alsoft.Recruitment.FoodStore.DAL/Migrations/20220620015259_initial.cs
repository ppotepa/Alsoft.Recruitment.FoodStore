using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscountTypes",
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
                    table.PrimaryKey("PK_DiscountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitTypes",
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
                    table.PrimaryKey("PK_UnitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercentage = table.Column<double>(type: "float", nullable: false),
                    DiscountTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_DiscountTypes_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalTable: "DiscountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
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
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_UnitTypes_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_DiscountProduct_Discounts_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StringValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductProperties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiscountTypes",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "EnumerationId", "EnumerationName", "ModifiedOn", "TypeId" },
                values: new object[,]
                {
                    { new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"), new DateTime(2022, 6, 20, 3, 52, 59, 355, DateTimeKind.Local).AddTicks(2743), false, null, 1, "DiscountType", null, new Guid("92bd474e-13d6-3831-9536-44eb75ac962a") },
                    { new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"), new DateTime(2022, 6, 20, 3, 52, 59, 356, DateTimeKind.Local).AddTicks(5645), false, null, 2, "DiscountType", null, new Guid("92bd474e-13d6-3831-9536-44eb75ac962a") },
                    { new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"), new DateTime(2022, 6, 20, 3, 52, 59, 356, DateTimeKind.Local).AddTicks(5700), false, null, 3, "DiscountType", null, new Guid("92bd474e-13d6-3831-9536-44eb75ac962a") }
                });

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "EnumerationId", "EnumerationName", "ModifiedOn", "TypeId" },
                values: new object[,]
                {
                    { new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2137), false, null, 3, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2195), false, null, 1, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2226), false, null, 4, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2255), false, null, 5, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") },
                    { new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2282), false, null, 2, "UnitType", null, new Guid("3a4529b2-6f93-3b11-94cc-cdc25ef5c89d") }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedOn", "DateFrom", "DateTo", "Deleted", "DeletedOn", "DiscountPercentage", "DiscountTypeId", "ModifiedOn", "TargetProductId" },
                values: new object[] { new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"), new DateTime(2022, 6, 20, 3, 52, 59, 358, DateTimeKind.Local).AddTicks(6158), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 10.0, new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"), null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "ModifiedOn", "Name", "Price", "UnitTypeId" },
                values: new object[,]
                {
                    { new Guid("598b7145-5444-454d-a619-81ca82f506de"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2673), false, null, null, "Soup", 0.65m, new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c") },
                    { new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3345), false, null, null, "Bread", 0.80m, new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c") },
                    { new Guid("6cd1c643-e710-4115-92b1-678925181d7b"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3379), false, null, null, "Roll", 0.30m, new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c") },
                    { new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3408), false, null, null, "Full-Cream Milk", 1.60m, new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c") },
                    { new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3436), false, null, null, "Low Fat Milk", 1.60m, new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c") },
                    { new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"), new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3464), false, null, null, "Apples", 1.00m, new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c") }
                });

            migrationBuilder.InsertData(
                table: "ProductProperties",
                columns: new[] { "Id", "CreatedOn", "Deleted", "DeletedOn", "ModifiedOn", "Name", "ProductId", "StringValue" },
                values: new object[,]
                {
                    { new Guid("6f029c5e-4433-4cd0-ae6a-677be0c1e3e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Flavour", new Guid("598b7145-5444-454d-a619-81ca82f506de"), "Chicken" },
                    { new Guid("19fce08f-5e9c-4d01-9acd-c9a53a8fbd7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Calories", new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"), "251" },
                    { new Guid("118aece2-2c32-4dac-bd42-7f66e230d9b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Flavour", new Guid("6cd1c643-e710-4115-92b1-678925181d7b"), "Chicken" },
                    { new Guid("e35732bc-520b-492e-9210-7580ffcfc071"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Fat Percentage", new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"), "3,2" },
                    { new Guid("c5674188-6e70-44f1-9dba-83f7b1c04dfe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Fat Percentage", new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"), "1,5" },
                    { new Guid("407b5697-ce5f-4b3d-b737-71bcee70b1ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "Origin", new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"), "Poland" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProduct_ProductsId",
                table: "DiscountProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_DiscountTypeId",
                table: "Discounts",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProperties_ProductId",
                table: "ProductProperties",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitTypeId",
                table: "Products",
                column: "UnitTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountProduct");

            migrationBuilder.DropTable(
                name: "ProductProperties");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "DiscountTypes");

            migrationBuilder.DropTable(
                name: "UnitTypes");
        }
    }
}
