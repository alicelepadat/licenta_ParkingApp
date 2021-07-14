using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_ParkingAreas_ParkingAreaId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Admin_User_UserId",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admins");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_UserId",
                table: "Admins",
                newName: "IX_Admins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_ParkingAreaId",
                table: "Admins",
                newName: "IX_Admins_ParkingAreaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 313, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 407, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 408, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 409, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 11, 27, 11, 410, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Password" },
                values: new object[] { new DateTime(2021, 7, 14, 11, 27, 10, 706, DateTimeKind.Local).AddTicks(150), "$2a$11$3vuPnYMPm6iU3okyLr1cLODpscZd1OzMPU5CUqNgGKZ09Xf2j/g3m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Password" },
                values: new object[] { new DateTime(2021, 7, 14, 11, 27, 11, 19, DateTimeKind.Local).AddTicks(4691), "$2a$11$6WzdRkk79t/UBa4nAfi0LeGj97pZ7vrP.zYagACaxopKoAoxckFfO" });

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_ParkingAreas_ParkingAreaId",
                table: "Admins",
                column: "ParkingAreaId",
                principalTable: "ParkingAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_User_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_ParkingAreas_ParkingAreaId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_User_UserId",
                table: "Admins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_UserId",
                table: "Admin",
                newName: "IX_Admin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_ParkingAreaId",
                table: "Admin",
                newName: "IX_Admin_ParkingAreaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 808, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 885, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedOn",
                value: new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Password" },
                values: new object[] { new DateTime(2021, 7, 14, 1, 38, 30, 463, DateTimeKind.Local).AddTicks(1002), "$2a$11$mORWUuU8fov17MqHkRdoHupEq1O8Vc8B/eiKcR7Db61GFNBGro9uy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Password" },
                values: new object[] { new DateTime(2021, 7, 14, 1, 38, 30, 639, DateTimeKind.Local).AddTicks(1852), "$2a$11$72iv7TSNVDWqLSFTFwodqe5l/3LzJuH3aj7cGBfO4JzsfT8U92fyG" });

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_ParkingAreas_ParkingAreaId",
                table: "Admin",
                column: "ParkingAreaId",
                principalTable: "ParkingAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_User_UserId",
                table: "Admin",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
