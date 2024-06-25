using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddHangFire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d52431a6-b4d6-4a74-958d-2b7686a4ec99"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dca1915c-7c1d-43c7-bcb1-90e5f60be527"));

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
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 24, 38, 355, DateTimeKind.Local).AddTicks(1246), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 29.670236731094760m, 488.01m, "Generic Metal Soap" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("d52431a6-b4d6-4a74-958d-2b7686a4ec99"), "cc3207e3-ad1d-4a51-9d4d-4381920e424b", "Admin", "ADMIN" },
                    { new Guid("dca1915c-7c1d-43c7-bcb1-90e5f60be527"), "9ce046d8-85ed-4aca-bb52-752e9bd4f797", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 414, DateTimeKind.Local).AddTicks(2538), "Baby, Home & Grocery" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 414, DateTimeKind.Local).AddTicks(2548), "Clothing" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 414, DateTimeKind.Local).AddTicks(2563), "Clothing & Games" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 20, 21, 12, 41, 415, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 20, 21, 12, 41, 415, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 20, 21, 12, 41, 415, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 5, 20, 21, 12, 41, 415, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 418, DateTimeKind.Local).AddTicks(1018), "Nemo est maiores tenetur animi.", "Rerum." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 418, DateTimeKind.Local).AddTicks(1054), "Dolor aut perferendis quis fugiat.", "Ratione distinctio." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 418, DateTimeKind.Local).AddTicks(1094), "Laudantium est non et officiis.", "Nihil." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 421, DateTimeKind.Local).AddTicks(4857), "The Football Is Good For Training And Recreational Purposes", 46.599643699216920m, 602.01m, "Ergonomic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 421, DateTimeKind.Local).AddTicks(4910), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 41.05307961058920m, 142.37m, "Licensed Steel Pants" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 12, 41, 421, DateTimeKind.Local).AddTicks(4931), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 31.846765257269360m, 1057.52m, "Unbranded Soft Soap" });
        }
    }
}
