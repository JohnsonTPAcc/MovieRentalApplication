using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalApplication.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedcustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35ae060e-b6e3-442e-9b3a-ebaef5e39b03", "AQAAAAIAAYagAAAAEMEtsTItEIg8faTW3pJ8FgM4Mnb6VQVcnDwHbYsBLYJex5Il+0l7wxCSond+8ACLsA==", "eb526782-f98c-4061-a014-0ac726cee2ce" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5366), new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5718), new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5897), new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 1, 28, 6, 26, 17, 827, DateTimeKind.Local).AddTicks(5899) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "795ae2f0-efaf-48ec-92e7-8888bc6b7b24", "AQAAAAIAAYagAAAAED9tgEdyMP1gy2aT3CfqhKtaEXsy8BiRGdUEpagtL/pThNBoQ1gNkDyYpAUoLDrN4Q==", "ff695f44-31f7-4162-9271-a8ce89b44a28" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9547), new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9548), new DateTime(2024, 1, 28, 5, 57, 37, 412, DateTimeKind.Local).AddTicks(9549) });
        }
    }
}
