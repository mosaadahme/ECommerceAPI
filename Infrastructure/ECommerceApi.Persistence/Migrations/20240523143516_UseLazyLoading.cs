using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UseLazyLoading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AddedOnDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 312, DateTimeKind.Local).AddTicks(5122), 18.820007122443120m, 1664.44m, "Incredible Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 35, 15, 312, DateTimeKind.Local).AddTicks(5161), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 49.387377110456120m, 1468.54m, "Unbranded Granite Table" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AddedOnDate", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 459, DateTimeKind.Local).AddTicks(4324), 38.858983821461080m, 250.45m, "Gorgeous Soft Hat" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 5, 21, 11, 29, 19, 459, DateTimeKind.Local).AddTicks(4389), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 34.714320135693840m, 463.20m, "Intelligent Frozen Pizza" });
        }
    }
}
