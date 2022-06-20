using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alsoft.Recruitment.FoodStore.DAL.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiscountTypes",
                keyColumn: "Id",
                keyValue: new Guid("0c390e11-691a-4627-9953-d5d1adfb983a"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 355, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "DiscountTypes",
                keyColumn: "Id",
                keyValue: new Guid("96b66163-9c3b-4de4-8671-15242cdf6892"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 356, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "DiscountTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc2ee7b8-aa70-4c44-b208-b18574507959"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 356, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: new Guid("7195f0a1-ed36-4817-acb8-70ec69501178"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 358, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34f233bb-1ab8-4107-96ab-42c67321745e"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("598b7145-5444-454d-a619-81ca82f506de"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c643-e710-4115-92b1-678925181d7b"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96af5685-6900-4345-ab1f-afcf5cf4e23c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1bb369e-2d55-44c1-bb37-7a88aea04eef"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c055f571-5e0b-4e4e-8f8a-759db75d00ab"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("090b50b4-51cf-4bb9-89a8-4bbb26eb7342"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("0fd52a86-6972-4f05-9cbf-14c8524f91d9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("6c4df377-0c6d-4a36-88d5-0ea46818edb9"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("c59a689d-89fa-48ca-9e4a-c2d27ece412c"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "UnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("e7e28ccf-4c0c-4299-b854-07c8a4b8420f"),
                column: "CreatedOn",
                value: new DateTime(2022, 6, 20, 3, 52, 59, 357, DateTimeKind.Local).AddTicks(2226));
        }
    }
}
