using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Reservations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Reservations",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 223, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 224, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 225, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 226, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 14, 55, 28, 113, DateTimeKind.Local).AddTicks(1854));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 443, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 12, 11, 12, 41, 360, DateTimeKind.Local).AddTicks(3960));
        }
    }
}
