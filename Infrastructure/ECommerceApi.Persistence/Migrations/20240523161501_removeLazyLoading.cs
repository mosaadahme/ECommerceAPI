using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class removeLazyLoading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27f01745-6f83-494d-92a8-ae9e184fd271"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("978092f1-37a3-496d-8578-314e5ffb818d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("27f01745-6f83-494d-92a8-ae9e184fd271"), "cb429a54-b095-45e5-a2ac-aa34469af54d", "Admin", "ADMIN" },
                    { new Guid("978092f1-37a3-496d-8578-314e5ffb818d"), "9d814444-5bdd-4174-b589-f10c866320ad", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 302, DateTimeKind.Local).AddTicks(4874), "Industrial" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 302, DateTimeKind.Local).AddTicks(4889), "Electronics" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 302, DateTimeKind.Local).AddTicks(4902), "Toys" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 17, 35, 15, 305, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 17, 35, 15, 305, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 17, 35, 15, 305, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 23, 17, 35, 15, 305, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 307, DateTimeKind.Local).AddTicks(7642), "Laboriosam voluptatem nihil enim vel.", "Eveniet." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 307, DateTimeKind.Local).AddTicks(7710), "Nihil numquam quibusdam nesciunt qui.", "Consequuntur labore." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 307, DateTimeKind.Local).AddTicks(7762), "Ut occaecati eos adipisci eum.", "Sint." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 312, DateTimeKind.Local).AddTicks(5080), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 36.187889617118160m, 1279.43m, "Small Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 312, DateTimeKind.Local).AddTicks(5122), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 18.820007122443120m, 1664.44m, "Incredible Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 312, DateTimeKind.Local).AddTicks(5161), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 49.387377110456120m, 1468.54m, "Unbranded Granite Table" });
        }
    }
}
