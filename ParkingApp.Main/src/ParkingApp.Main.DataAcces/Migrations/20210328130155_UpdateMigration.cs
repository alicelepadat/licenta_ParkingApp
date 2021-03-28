using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 957, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 879, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 16, 1, 54, 958, DateTimeKind.Local).AddTicks(4988));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 912, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 831, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 3, 28, 15, 56, 8, 913, DateTimeKind.Local).AddTicks(1926));
        }
    }
}
