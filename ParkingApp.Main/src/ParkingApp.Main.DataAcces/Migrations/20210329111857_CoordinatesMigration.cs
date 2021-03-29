using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class CoordinatesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 2, new DateTime(2021, 3, 29, 14, 18, 50, 244, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2021, 3, 29, 14, 18, 52, 424, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2021, 3, 29, 14, 18, 53, 347, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 5, new DateTime(2021, 3, 29, 14, 18, 54, 415, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 6, new DateTime(2021, 3, 29, 14, 18, 55, 752, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 18, 50, 124, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 18, 52, 424, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 18, 53, 347, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 18, 54, 415, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 18, 55, 752, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 18, 56, 480, DateTimeKind.Local).AddTicks(6703));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 3, 29, 14, 16, 28, 90, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 3, 29, 14, 16, 29, 738, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 3, 29, 14, 16, 31, 546, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 3, 29, 14, 16, 32, 993, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 3, 29, 14, 16, 33, 528, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 16, 27, 965, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 16, 29, 738, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 16, 31, 546, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 16, 32, 993, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 16, 33, 528, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 29, 14, 16, 34, 246, DateTimeKind.Local).AddTicks(2118));
        }
    }
}
