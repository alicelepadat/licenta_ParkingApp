using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 5, 17, 15, 45, 383, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.InsertData(
                table: "Coordinates",
                columns: new[] { "Id", "CreatedOn", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.437579499999998, 26.0980755 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.461201299999999, 26.099996600000001 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.427555900000002, 26.113038800000002 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.516416100000001, 26.091535700000001 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.4343279, 26.097335300000001 }
                });

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 5, 17, 15, 46, 733, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 5, 17, 15, 47, 253, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 5, 17, 15, 47, 710, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 5, 17, 15, 48, 78, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 5, 17, 15, 48, 576, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 2, new DateTime(2021, 4, 5, 17, 15, 45, 701, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 3, new DateTime(2021, 4, 5, 17, 15, 46, 734, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 4, new DateTime(2021, 4, 5, 17, 15, 47, 253, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 5, new DateTime(2021, 4, 5, 17, 15, 47, 710, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { 6, new DateTime(2021, 4, 5, 17, 15, 48, 78, DateTimeKind.Local).AddTicks(1962) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 4, 3, 19, 23, 39, 916, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CoordinatesId", "CreatedOn" },
                values: new object[] { null, new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 19, 23, 39, 840, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 19, 23, 39, 917, DateTimeKind.Local).AddTicks(1783));
        }
    }
}
