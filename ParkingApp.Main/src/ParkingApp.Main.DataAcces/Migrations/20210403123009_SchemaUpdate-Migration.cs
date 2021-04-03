using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class SchemaUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 248, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 157, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 15, 30, 8, 249, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 527, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 3, 11, 55, 53, 619, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations",
                column: "VehicleId",
                unique: true,
                filter: "[VehicleId] IS NOT NULL");
        }
    }
}
