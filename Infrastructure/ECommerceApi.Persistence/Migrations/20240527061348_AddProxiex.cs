using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddProxiex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("561c4288-9339-496b-b448-9a4300d80365"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("93cc193e-661e-453c-8961-70a6200e0e41"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0db93014-3efb-4962-8f52-0810ec07caf4"), "198aa0c0-2116-4b12-99a6-f27bc6d4e40c", "Admin", "ADMIN" },
                    { new Guid("7cbac320-cc39-4d2c-a5b0-c9d1ad031de6"), "9f6a1bbb-316d-40a3-bcd9-77fb2ae13be3", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 660, DateTimeKind.Local).AddTicks(7718), "Movies, Home & Baby" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 660, DateTimeKind.Local).AddTicks(7734), "Electronics" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 660, DateTimeKind.Local).AddTicks(7755), "Sports & Shoes" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 27, 9, 13, 47, 663, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 27, 9, 13, 47, 663, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 27, 9, 13, 47, 663, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 27, 9, 13, 47, 663, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 665, DateTimeKind.Local).AddTicks(9253), "Quia exercitationem est ipsum doloribus.", "In." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 665, DateTimeKind.Local).AddTicks(9310), "Est libero voluptatem voluptatum cum.", "Odio quia." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 665, DateTimeKind.Local).AddTicks(9358), "Suscipit dolor aut mollitia unde.", "Sunt." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 671, DateTimeKind.Local).AddTicks(3802), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 36.403078612250120m, 1358.28m, "Intelligent Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 671, DateTimeKind.Local).AddTicks(3847), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10.9629662341846040m, 1771.41m, "Practical Soft Chips" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 13, 47, 671, DateTimeKind.Local).AddTicks(3886), "The Football Is Good For Training And Recreational Purposes", 14.13118474041880m, 788.31m, "Refined Cotton Pizza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0db93014-3efb-4962-8f52-0810ec07caf4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cbac320-cc39-4d2c-a5b0-c9d1ad031de6"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("561c4288-9339-496b-b448-9a4300d80365"), "fd1801d6-a31f-400e-9d29-d5807c9da393", "Admin", "ADMIN" },
                    { new Guid("93cc193e-661e-453c-8961-70a6200e0e41"), "c75ef958-a753-4d36-98e9-d91e6435f0cc", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 96, DateTimeKind.Local).AddTicks(9557), "Outdoors" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 96, DateTimeKind.Local).AddTicks(9611), "Grocery, Games & Kids" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 96, DateTimeKind.Local).AddTicks(9619), "Games" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 19, 15, 1, 98, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 19, 15, 1, 98, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 19, 15, 1, 98, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 19, 15, 1, 98, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 100, DateTimeKind.Local).AddTicks(6041), "Et deleniti libero totam doloribus.", "Error." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 100, DateTimeKind.Local).AddTicks(6080), "Fugit beatae eos eius consequuntur.", "Possimus voluptatem." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 100, DateTimeKind.Local).AddTicks(6119), "Dolorum et sit molestiae laboriosam.", "Quo." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 103, DateTimeKind.Local).AddTicks(6658), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 19.027148871286200m, 300.15m, "Refined Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 103, DateTimeKind.Local).AddTicks(6687), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 33.268430269039800m, 133.35m, "Generic Cotton Table" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 15, 1, 103, DateTimeKind.Local).AddTicks(6712), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 11.6818550640350560m, 1625.76m, "Awesome Cotton Pizza" });
        }
    }
}
