using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieRentalApplication.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7feb4473-6eac-437f-ac87-0a352352d2d9", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEA/iPa1KsD1osU4sx65lKAlbKtypTR7UYuNNxm2uZCJMZbxeL9sYd/Re9A3+yfTutQ==", null, false, "845e4735-ae22-4ce7-abe6-086051c201f5", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8172), new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8183), "SciFi", "System" },
                    { 2, "System", new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8185), "Horror", "System" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8504), "Christopher Nolan", "System" },
                    { 2, "System", new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8505), "John Carpenter", "System" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8687), new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8688), "PG", "System" },
                    { 2, "System", new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8689), new DateTime(2024, 1, 28, 2, 42, 10, 465, DateTimeKind.Local).AddTicks(8690), "PG 13", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
