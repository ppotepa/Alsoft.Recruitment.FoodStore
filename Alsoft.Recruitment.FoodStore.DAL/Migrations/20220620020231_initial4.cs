using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 589, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 586, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 587, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "DiscountType",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 587, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "UnitType",
                keyColumn: "Id",
                keyValue: new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 4, 2, 31, 588, DateTimeKind.Local).AddTicks(5638));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
