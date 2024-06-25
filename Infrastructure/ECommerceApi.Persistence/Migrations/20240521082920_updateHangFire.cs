using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateHangFire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30f78db3-7ade-4810-92ad-df2563d7cb83"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e5fd5f62-78e4-490a-8184-aa2ec7113d5f"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3c763fe5-4595-468e-b3ee-722e17244297"), "d1ff8400-b40a-47e2-ba22-5408ddc20c12", "User", "USER" },
                    { new Guid("e74133d4-0a2b-46e6-afe2-44b7c6b1e2b2"), "218213c8-0ad9-4222-b2df-938603a770c6", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 444, DateTimeKind.Local).AddTicks(7409), "Movies" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 444, DateTimeKind.Local).AddTicks(7474), "Tools & Toys" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 444, DateTimeKind.Local).AddTicks(7505), "Baby, Clothing & Garden" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 29, 19, 447, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 29, 19, 447, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 29, 19, 447, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 29, 19, 447, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 451, DateTimeKind.Local).AddTicks(8542), "Sit error omnis excepturi beatae.", "Impedit." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 451, DateTimeKind.Local).AddTicks(8634), "At rerum et ea atque.", "Eum dolores." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 451, DateTimeKind.Local).AddTicks(8713), "Qui et corrupti omnis vero.", "Beatae." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 459, DateTimeKind.Local).AddTicks(4254), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 35.354111968957000m, 240.62m, "Small Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 459, DateTimeKind.Local).AddTicks(4324), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 38.858983821461080m, 250.45m, "Gorgeous Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 459, DateTimeKind.Local).AddTicks(4389), 34.714320135693840m, 463.20m, "Intelligent Frozen Pizza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3c763fe5-4595-468e-b3ee-722e17244297"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e74133d4-0a2b-46e6-afe2-44b7c6b1e2b2"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("30f78db3-7ade-4810-92ad-df2563d7cb83"), "a1293466-d19a-4be4-a341-8a740033c177", "Admin", "ADMIN" },
                    { new Guid("e5fd5f62-78e4-490a-8184-aa2ec7113d5f"), "597e39ef-00fe-4e0c-a894-9ff53d457a4f", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 345, DateTimeKind.Local).AddTicks(5687), "Kids, Home & Clothing" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 345, DateTimeKind.Local).AddTicks(5705), "Electronics" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 345, DateTimeKind.Local).AddTicks(5736), "Electronics, Outdoors & Baby" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 24, 38, 348, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 24, 38, 348, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 24, 38, 348, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 21, 11, 24, 38, 348, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 350, DateTimeKind.Local).AddTicks(5862), "Qui illo expedita ipsum dolor.", "Pariatur." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 350, DateTimeKind.Local).AddTicks(5920), "Quia est fugit qui non.", "Molestiae sed." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 350, DateTimeKind.Local).AddTicks(5978), "Ut est adipisci impedit laborum.", "Odit." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 355, DateTimeKind.Local).AddTicks(1165), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 21.17821689124440m, 1703.27m, "Ergonomic Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 355, DateTimeKind.Local).AddTicks(1208), "The Football Is Good For Training And Recreational Purposes", 26.590919210653640m, 179.31m, "Generic Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 355, DateTimeKind.Local).AddTicks(1246), 29.670236731094760m, 488.01m, "Generic Metal Soap" });
        }
    }
}
