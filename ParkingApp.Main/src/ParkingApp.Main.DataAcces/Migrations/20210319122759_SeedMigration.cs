using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "County", "CreatedOn", "Directions", "Number", "Street" },
                values: new object[,]
                {
                    { 2, "Bucuresti", "Sector 1", new DateTime(2021, 3, 19, 14, 27, 58, 265, DateTimeKind.Local).AddTicks(6505), "Între bd. Regina Elisabeta și I. Campineanu", 0, "Academiei" },
                    { 3, "Bucuresti", "Sector 1", new DateTime(2021, 3, 19, 14, 27, 58, 266, DateTimeKind.Local).AddTicks(9641), "", 0, "Alee Legatura Banu Antonache si Calea Floreasca" },
                    { 4, "Bucuresti", "Sector 3", new DateTime(2021, 3, 19, 14, 27, 58, 267, DateTimeKind.Local).AddTicks(28), "INTERSECTIA CU BD. MIRCEA VODA", 0, "ALEEA CAUZASI" },
                    { 5, "Bucuresti", "Sector 1", new DateTime(2021, 3, 19, 14, 27, 58, 267, DateTimeKind.Local).AddTicks(153), "INTRE AL.PRIVIGHETORILOR SI SERBAN CANTACUZINO", 1, "ALEEA PRIVIGHETORILOR" },
                    { 6, "Bucuresti", "Sector 5", new DateTime(2021, 3, 19, 14, 27, 58, 267, DateTimeKind.Local).AddTicks(248), "", 0, "ALEXANDRU BELDIMAN" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CompanyName", "CreatedOn" },
                values: new object[] { 1, "Administrația Străzilor București", new DateTime(2021, 3, 19, 14, 27, 58, 125, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AddressId", "AvailableSpots", "CompanyId", "CreatedOn", "PricePerHour" },
                values: new object[,]
                {
                    { 2, 2, 96, 1, new DateTime(2021, 3, 19, 14, 27, 58, 266, DateTimeKind.Local).AddTicks(7312), 0m },
                    { 3, 3, 29, 1, new DateTime(2021, 3, 19, 14, 27, 58, 266, DateTimeKind.Local).AddTicks(9898), 3.99m },
                    { 4, 4, 8, 1, new DateTime(2021, 3, 19, 14, 27, 58, 267, DateTimeKind.Local).AddTicks(61), 5.99m },
                    { 5, 5, 59, 1, new DateTime(2021, 3, 19, 14, 27, 58, 267, DateTimeKind.Local).AddTicks(175), 4.99m },
                    { 6, 6, 56, 1, new DateTime(2021, 3, 19, 14, 27, 58, 267, DateTimeKind.Local).AddTicks(270), 9.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
