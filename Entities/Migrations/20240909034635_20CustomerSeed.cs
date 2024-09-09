using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class _20CustomerSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Created", "Email", "FirstName", "LastName", "Modify" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(18), "john.doe@example.com", "John", "Doe", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(19) },
                    { 2, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(25), "jane.smith@example.com", "Jane", "Smith", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(26) },
                    { 3, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(31), "alice.johnson@example.com", "Alice", "Johnson", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(32) },
                    { 4, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(35), "bob.williams@example.com", "Bob", "Williams", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(36) },
                    { 5, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(40), "charlie.brown@example.com", "Charlie", "Brown", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(41) },
                    { 6, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(45), "david.miller@example.com", "David", "Miller", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(46) },
                    { 7, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(49), "emily.davis@example.com", "Emily", "Davis", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(50) },
                    { 8, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(54), "frank.garcia@example.com", "Frank", "Garcia", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(55) },
                    { 9, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(58), "grace.martinez@example.com", "Grace", "Martinez", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(59) },
                    { 10, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(62), "henry.lopez@example.com", "Henry", "Lopez", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(63) },
                    { 11, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(67), "irene.gonzalez@example.com", "Irene", "Gonzalez", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(68) },
                    { 12, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(71), "jack.wilson@example.com", "Jack", "Wilson", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(72) },
                    { 13, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(76), "karen.anderson@example.com", "Karen", "Anderson", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(77) },
                    { 14, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(81), "liam.thomas@example.com", "Liam", "Thomas", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(82) },
                    { 15, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(85), "mia.taylor@example.com", "Mia", "Taylor", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(85) },
                    { 16, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(89), "nathan.moore@example.com", "Nathan", "Moore", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(90) },
                    { 17, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(93), "olivia.jackson@example.com", "Olivia", "Jackson", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(94) },
                    { 18, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(97), "paul.lee@example.com", "Paul", "Lee", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(98) },
                    { 19, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(101), "quincy.harris@example.com", "Quincy", "Harris", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(102) },
                    { 20, new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(106), "rachel.clark@example.com", "Rachel", "Clark", new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(106) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
