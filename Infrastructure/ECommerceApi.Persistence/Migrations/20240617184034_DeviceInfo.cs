using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DeviceInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0db93014-3efb-4962-8f52-0810ec07caf4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cbac320-cc39-4d2c-a5b0-c9d1ad031de6"));

            migrationBuilder.CreateTable(
                name: "deviceInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Browser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoggedInAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deviceInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1ba9417a-3bfe-41ca-a4ce-e11d85b4d306"), "a9f18f91-86eb-4aa2-a4d0-ef513a1d9238", "Admin", "ADMIN" },
                    { new Guid("32f8aef6-de20-47cc-b9ef-3ad74f18a758"), "0116498c-269a-4eb7-b250-fe20eed0d3f9", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 295, DateTimeKind.Local).AddTicks(9173), "Beauty & Industrial" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 295, DateTimeKind.Local).AddTicks(9271), "Clothing, Clothing & Automotive" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 295, DateTimeKind.Local).AddTicks(9287), "Health & Electronics" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 17, 21, 40, 34, 297, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 17, 21, 40, 34, 297, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 17, 21, 40, 34, 297, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 17, 21, 40, 34, 297, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 299, DateTimeKind.Local).AddTicks(2760), "Dicta excepturi necessitatibus tempora adipisci.", "Iste." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 299, DateTimeKind.Local).AddTicks(2796), "Laborum et id a facere.", "Id non." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 299, DateTimeKind.Local).AddTicks(2828), "Harum consectetur eveniet voluptatem itaque.", "Odio." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 302, DateTimeKind.Local).AddTicks(2757), "The Football Is Good For Training And Recreational Purposes", 13.2312212440389560m, 1827.16m, "Gorgeous Metal Soap" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 302, DateTimeKind.Local).AddTicks(2785), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 47.250362006958680m, 1453.01m, "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 17, 21, 40, 34, 302, DateTimeKind.Local).AddTicks(2809), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 43.45253204449400m, 1578.86m, "Rustic Steel Pizza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deviceInfo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ba9417a-3bfe-41ca-a4ce-e11d85b4d306"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32f8aef6-de20-47cc-b9ef-3ad74f18a758"));

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
    }
}
