using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_DrivingLicense_LicenseId",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_LicenseId",
                table: "Drivers");

            migrationBuilder.AlterColumn<int>(
                name: "LicenseId",
                table: "Drivers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_LicenseId",
                table: "Drivers",
                column: "LicenseId",
                unique: true,
                filter: "[LicenseId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_DrivingLicense_LicenseId",
                table: "Drivers",
                column: "LicenseId",
                principalTable: "DrivingLicense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_DrivingLicense_LicenseId",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_LicenseId",
                table: "Drivers");

            migrationBuilder.AlterColumn<int>(
                name: "LicenseId",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_LicenseId",
                table: "Drivers",
                column: "LicenseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_DrivingLicense_LicenseId",
                table: "Drivers",
                column: "LicenseId",
                principalTable: "DrivingLicense",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
