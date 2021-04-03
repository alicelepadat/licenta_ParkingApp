using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Issuer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issuer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Directions = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    County = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CoordinatesId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Coordinates_CoordinatesId",
                        column: x => x.CoordinatesId,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrivingLicense_Issuer_IssuerId",
                        column: x => x.IssuerId,
                        principalTable: "Issuer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkingAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalSpots = table.Column<int>(type: "int", nullable: false),
                    AvailableSpots = table.Column<int>(type: "int", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingAreas_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParkingAreas_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LicenseId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_DrivingLicense_LicenseId",
                        column: x => x.LicenseId,
                        principalTable: "DrivingLicense",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drivers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ParkingAreaId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Admin_ParkingAreas_ParkingAreaId",
                        column: x => x.ParkingAreaId,
                        principalTable: "ParkingAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admin_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true),
                    ParkingAreaId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_ParkingAreas_ParkingAreaId",
                        column: x => x.ParkingAreaId,
                        principalTable: "ParkingAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "CoordinatesId", "County", "CreatedOn", "Directions", "Street" },
                values: new object[,]
                {
                    { 2, "Bucuresti", null, "Sector 1", new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(2756), "Între bd. Regina Elisabeta și I. Campineanu", "Academiei" },
                    { 3, "Bucuresti", null, "Sector 1", new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8435), "", "Alee Legatura Banu Antonache si Calea Floreasca" },
                    { 4, "Bucuresti", null, "Sector 3", new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8545), "INTERSECTIA CU BD. MIRCEA VODA", "ALEEA CAUZASI" },
                    { 5, "Bucuresti", null, "Sector 1", new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8599), "INTRE AL.PRIVIGHETORILOR SI SERBAN CANTACUZINO", "ALEEA PRIVIGHETORILOR" },
                    { 6, "Bucuresti", null, "Sector 5", new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8653), "", "ALEXANDRU BELDIMAN" }
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CompanyName", "CreatedOn" },
                values: new object[] { 1, "Administrația Străzilor București", new DateTime(2021, 4, 3, 11, 46, 7, 179, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AddressId", "AvailableSpots", "CompanyId", "CreatedOn", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 2, 2, 96, 1, new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(7688), 0m, 96 },
                    { 3, 3, 29, 1, new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8486), 0m, 29 },
                    { 4, 4, 8, 1, new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8561), 0m, 8 },
                    { 5, 5, 59, 1, new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8614), 0m, 59 },
                    { 6, 6, 56, 1, new DateTime(2021, 4, 3, 11, 46, 7, 250, DateTimeKind.Local).AddTicks(8667), 0m, 56 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CoordinatesId",
                table: "Address",
                column: "CoordinatesId",
                unique: true,
                filter: "[CoordinatesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_CompanyId",
                table: "Admin",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_ParkingAreaId",
                table: "Admin",
                column: "ParkingAreaId",
                unique: true,
                filter: "[ParkingAreaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserId",
                table: "Admin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_LicenseId",
                table: "Drivers",
                column: "LicenseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_UserId",
                table: "Drivers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLicense_IssuerId",
                table: "DrivingLicense",
                column: "IssuerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParkingAreas_AddressId",
                table: "ParkingAreas",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParkingAreas_CompanyId",
                table: "ParkingAreas",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ParkingAreaId",
                table: "Reservations",
                column: "ParkingAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_DriverId",
                table: "Vehicle",
                column: "DriverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "ParkingAreas");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "DrivingLicense");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Issuer");
        }
    }
}
