using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ba9417a-3bfe-41ca-a4ce-e11d85b4d306"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("32f8aef6-de20-47cc-b9ef-3ad74f18a758"));

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddedOnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ddbeefa6-2d1c-4f0b-97a7-0022c3bf936c"), "ea226a12-6fb0-4cd9-80b2-6baac6f96f3c", "Admin", "ADMIN" },
                    { new Guid("e84b9a78-d93a-40e4-aec5-96ac500469a9"), "3e0dc322-b0ed-4579-a3a4-d534e8e4e3d5", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 137, DateTimeKind.Local).AddTicks(6092), "Shoes, Games & Computers" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 137, DateTimeKind.Local).AddTicks(6110), "Garden, Sports & Toys" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Name" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 137, DateTimeKind.Local).AddTicks(6126), "Automotive, Beauty & Sports" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 24, 10, 1, 50, 139, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 24, 10, 1, 50, 139, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 24, 10, 1, 50, 139, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOnDate",
                value: new DateTime(2024, 6, 24, 10, 1, 50, 139, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 141, DateTimeKind.Local).AddTicks(9634), "Unde voluptas et est in.", "Quia." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 141, DateTimeKind.Local).AddTicks(9686), "Eaque blanditiis maiores deleniti est.", "Aperiam provident." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 141, DateTimeKind.Local).AddTicks(9731), "Dignissimos numquam rerum est corporis.", "Et." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 146, DateTimeKind.Local).AddTicks(8391), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 49.198531389924360m, 1598.14m, "Licensed Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 146, DateTimeKind.Local).AddTicks(8421), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 39.1090340541520m, 746.20m, "Fantastic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOnDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 1, 50, 146, DateTimeKind.Local).AddTicks(8445), "The Football Is Good For Training And Recreational Purposes", 27.180608361801360m, 1186.43m, "Licensed Concrete Chips" });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_userId",
                table: "Transactions",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ddbeefa6-2d1c-4f0b-97a7-0022c3bf936c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e84b9a78-d93a-40e4-aec5-96ac500469a9"));

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
    }
}
