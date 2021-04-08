using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class NewAreasMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 44, 89, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 46, 590, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 48, 299, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 49, 737, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 50, 354, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 51, 890, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Street" },
                values: new object[] { new DateTime(2021, 4, 8, 20, 19, 52, 902, DateTimeKind.Local).AddTicks(350), "Pictor Verona" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 53, 878, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 43, 965, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 44.442591499999999, 26.1009323 });

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 46, 590, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 48, 299, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 49, 737, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 50, 354, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 51, 889, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 52, 901, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 53, 878, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 20, 19, 55, 258, DateTimeKind.Local).AddTicks(4778));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 47, 742, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 104, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 292, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 488, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 671, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 827, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Street" },
                values: new object[] { new DateTime(2021, 4, 8, 19, 39, 48, 993, DateTimeKind.Local).AddTicks(5400), "Arthur Verona" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 49, 755, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 47, 666, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 40.484963, -79.837450000000004 });

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 104, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 292, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 488, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 671, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 826, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 48, 993, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 49, 755, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 8, 19, 39, 50, 110, DateTimeKind.Local).AddTicks(2181));
        }
    }
}
