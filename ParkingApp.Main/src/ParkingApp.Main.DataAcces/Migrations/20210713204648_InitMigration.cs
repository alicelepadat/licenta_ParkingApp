using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrivingLicense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicense", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkingAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalSpots = table.Column<int>(type: "int", nullable: false),
                    AvailableSpots = table.Column<int>(type: "int", nullable: true),
                    PricePerHour = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmplacementLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingAreas", x => x.Id);
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
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ParkingAreaId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
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
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LicenseId = table.Column<int>(type: "int", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drivers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
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
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Drivers_DriverId",
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
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
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
                        name: "FK_Reservations_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 100, 96, "București", new DateTime(2021, 7, 13, 23, 46, 48, 49, DateTimeKind.Local).AddTicks(9454), "Academiei", "Între bd. Regina Elisabeta și I. Campineanu", 10m, 96 },
                    { 261, 156, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2831), "NICOLAE CARAMFIL", "BD. NICOLAE CARANFIL", 10m, 156 },
                    { 262, 98, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2875), "NICOLAE FILIPESCU", "INTRE STR. C.A. ROSETTI SI STR. BATISTEI", 10m, 98 },
                    { 263, 32, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2917), "NICOLAE GOLESCU", "INTRE STR. G. ENESCU SI STR. EPISCOPIEI", 5m, 32 },
                    { 264, 35, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2960), "NICOLAE IORGA", "INTRE CALEA VICTORIEI SI STR. HENRI COANDA", 5m, 35 },
                    { 265, 35, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3002), "NICOLAE TITULESCU", "INTRE INTR. COJESTI SI STR. DR. IACOB FELIX", 2.5m, 35 },
                    { 266, 163, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3045), "OCTAVIAN GOGA 1", "INTRE CALEA DUDESTI SI STR. NERVA TRAIAN", 2.5m, 163 },
                    { 267, 18, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3086), "OCTAVIAN GOGA 3", "ARTERA DREAPTA PASAJ MARASESTI", 5m, 18 },
                    { 268, 138, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3129), "OCTAVIAN GOGA 4", "DEASUPRA PASAJ MARASESTI", 5m, 138 },
                    { 269, 50, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3172), "OCTAVIAN GOGA 5", "DEASUPRA PASAJ MARASESTI - DREAPTA PARCAJ GOGA 4", 5m, 50 },
                    { 270, 80, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3214), "OPERA", "PTA. VICTOR BABES", 5m, 80 },
                    { 271, 12, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3256), "ORIZONT", "INTR. JEAN GEORGESCU, LA INTERSECTIA CU STR. DEM I. DOBRESCU", 10m, 12 },
                    { 272, 28, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3300), "OTETELESANU", "INTRE STR. MATEI MILLO SI STR. C-TIN MILLE", 5m, 28 },
                    { 273, 11, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3343), "PANIPAT", "BD. BRATIANU", 10m, 11 },
                    { 274, 266, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3386), "PANTELIMON 1S", "SOS. MORARILOR - SOS. VERGULUI", 2m, 266 },
                    { 275, 61, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3427), "PECO ANGHEL SALIGNY", "STR. ANGHEL SALIGNY", 5m, 61 },
                    { 276, 72, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3508), "PECO BARIERE", "SP. INDEPENDENTEI, INTRE STR. A. SALIGNY SI ELIE RADU", 5m, 72 },
                    { 277, 25, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3557), "PECO M.I.", "INTERSECTIE A. SALIGNY - LIPSCANI", 5m, 25 },
                    { 278, 13, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3600), "PECO POMPIERI", "INTRE STR. A. SALIGNY SI ELIE RADU", 5m, 13 },
                    { 279, 99, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3641), "PESCARUS", "ALEEA DE ACCES IN PARCUL HERASTRAU - LA RESTAURANTUL PESCARUS", 5m, 99 },
                    { 280, 80, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3683), "PIATA ALBA IULIA 1", "INTRE BD. UNIRII SI BD. DECEBAL (ALVEOLE)", 2.5m, 80 },
                    { 281, 77, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3725), "PIATA AMZEI 1", "INTRE CALEA VICTORIEI SI STR. MENDELEEV", 5m, 77 },
                    { 282, 65, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3768), "PIATA AMZEI 2", "INTRE STR. BISERICA AMZEI SI PIATA AMZEI", 5m, 65 },
                    { 283, 47, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3808), "PIATA AMZEI 3", "INTRE STR. CHRISTIAN TELL SI PIATA AMZEI", 5m, 47 },
                    { 284, 37, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3852), "PIATA CHARLES DE GAULLE", "ALVEOLE PARTEA DREAPTA P-TA CH. DE GAULLE (BD. PREZAN)", 5m, 37 },
                    { 285, 494, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3893), "PIATA CONSTITUTIEI", "PIATA CONSTITUTIEI - PASTILA (FARA ALVEOLE)", 5m, 494 },
                    { 286, 25, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3937), "PIATA GEMENI", "PIATA GEMENI", 5m, 25 },
                    { 287, 19, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(3977), "PIATA ITALIANA", "ITALIANA X STR. V. LASCAR X STR. C-TIN NACU", 5m, 19 },
                    { 260, 24, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2782), "NICOLAE BALCESCU 2", "INTRE STR. C.A. ROSETTI SI STR. DEM. I. DOBRESCU", 10m, 24 },
                    { 259, 44, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2701), "NICOLAE BALCESCU 1", "INTRE STR. DEM. I. DOBRESCU SI STR. I. CAMPINEANU", 10m, 44 },
                    { 258, 35, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2661), "NERVA TRAIAN", "", 5m, 35 },
                    { 257, 29, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2619), "NATIUNILE UNITE", "INTRE PTA. NATIUNILE UNITE SI STR. SF. APOSTOLI", 10m, 29 },
                    { 229, 52, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1403), "ION BREZOIANU 3", "INTRE WALTER MARACINEANU SI POIANA NARCISELOR", 5m, 52 },
                    { 230, 73, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1452), "ION CAMPINEANU", "INTRE CALEA VICTORIEI SI BD. N. BALCESCU", 10m, 73 },
                    { 231, 45, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1496), "ION CAMPINEANU (SUPERB)", "INTRE STR. STIRBEI VODA SI STR. W. MARACINEANU", 5m, 45 },
                    { 232, 57, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1537), "ION CAMPINEANU 1", "INTRE W.MARACINEANU SI CALEA VICTORIEI", 5m, 57 },
                    { 233, 24, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1577), "ION GHICA", "INTRE I.C.BRATIANU SI DOAMNEI", 10m, 24 },
                    { 234, 46, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1620), "JEAN LOUIS CALDERON 1", "INTRE ITALIANA SI C.A.ROSETTI", 10m, 46 },
                    { 235, 18, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1660), "JEAN LOUIS CALDERON 2", "INTRE C.A.ROSETTI SI ITALIANA", 10m, 18 },
                    { 236, 49, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1703), "JEAN LOUIS CALDERON 3", "INTRE ICOANEI SI PTA CANTACUZINO", 10m, 49 },
                    { 237, 84, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1744), "KISELEFF ALVEOLA", "INTRE MONETARIEI SI ION MINCU", 5m, 84 },
                    { 238, 15, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1787), "LASCAR CATARGIU – HOTEL MINERVA", "INTRE STR. H. COANDA SI STR. G-RAL GHE. MANU", 5m, 15 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 239, 44, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1827), "LIBERTATII", "INTRE BD. NATIUNILE UNITE SI SPLAIUL INDEPENDENTEI, PE PARTE ADIACENTA PARCULUI", 5m, 44 },
                    { 240, 11, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1869), "LIDO", "INTRE STR. ANASTASIE SINU SI STR. B. FRANKLIN", 5m, 11 },
                    { 241, 60, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1909), "LIDO TERASA", "INTRE CALEA VICTORIEI SI BD. MAGHERU", 5m, 60 },
                    { 288, 90, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4018), "PIATA LIBERTATII 1", "INTRE STR. C-TIN ISTRATI SI BD. MARASESTI (PARCUL CAROL)", 5m, 90 },
                    { 242, 27, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1950), "LIPSCANI 1", "INTRE STR. A.SALIGNY SI STR. I.BREZOIANU", 5m, 27 },
                    { 244, 53, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2071), "LUTERANA", "INTRE STR. STIRBEI VODA SI STR. G-RAL BERTHELOT", 5m, 53 },
                    { 245, 29, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2118), "MAGAZIN VICTORIA", "MAGAZIN VICTORIA", 5m, 29 },
                    { 246, 62, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2161), "MARIA ROSETTI", "INTRE STR ION LUCA CARAGIALE SI STR. SF SPIRIDON", 5m, 62 },
                    { 247, 43, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2201), "MARRIOTT", "ZONA PTA. ARSENALULUI", 5m, 43 },
                    { 248, 31, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2243), "MATEI BASARAB 1", "INTRE STR. MIRCEA VODA SI BD. CORNELIU COPOSU", 10m, 31 },
                    { 249, 55, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2285), "MATEI MILLO", "INTRE CALEA VICTORIEI SI STR. G. VRACA", 5m, 55 },
                    { 250, 113, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2326), "MENDELEEV", "STR. MENDELEEV, INTRE STR. G. ENESCU SI PTA. ROMANA", 5m, 113 },
                    { 251, 20, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2366), "MINISTERUL MEDIULUI", "BD. LIBERTATII", 5m, 20 },
                    { 252, 319, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2409), "MIRCEA VODA", "BD C. COPOSU - NERVA TRAIAN", 5m, 319 },
                    { 253, 20, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2451), "BD. MIRCEA VODA, HOTEL MERCURE", "", 5m, 20 },
                    { 254, 29, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2494), "BD. MIRCEA VODA, TIMPURI NOI", "INTERSECTIE BD. MIRCEA VODA SI STR. NERVA TRAIAN - PARC TIMPURI NOI", 5m, 29 },
                    { 255, 80, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2534), "MIRCEA VULCANESCU", "INTRE STR. D.GOLESCU SI CALEA PLEVNEI", 5m, 80 },
                    { 256, 88, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(2577), "MIRCEA VULCANESCU 1", "INTRE CALEA GRIVITEI SI STR. HORATIU", 5m, 88 },
                    { 243, 30, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1989), "LIPSCANI 2", "INTRE BD. I.C. BRATIANU SI CALEA MOSILOR", 5m, 30 },
                    { 289, 18, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4060), "PIATA LIBERTATII 2", "INTRE BD. MARASESTI SI STR. 11 IUNIE", 5m, 18 },
                    { 290, 136, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4102), "PIATA REVOLUTIEI", "INTRE STR. ION CAMPINEANU SI STR. DEM I. DOBRESCU", 5m, 136 },
                    { 291, 93, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4143), "PIATA VICTORIEI", "PTA. VICTORIEI (DEASUPRA PASAJULUI RUTIER)", 5m, 93 },
                    { 324, 384, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5656), "SOS. NORDULUI", "INTRE BD. BEIJING SI STR. GRIGORE GAFENCU", 5m, 384 },
                    { 325, 39, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5738), "SOS. NORDULUI – AMBASADA CHINEI", "INTRE BD. BEIJING SI ALEEA PRIPORULUI", 5m, 39 },
                    { 326, 39, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5785), "SPERANTEI", "INTRE STR. AR. CALINESCU SI CAROL I", 5m, 39 },
                    { 327, 24, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5828), "SPLAI EXIM BANK ALVEOLA", "SP. INDEPENDENTEI", 5m, 24 },
                    { 328, 44, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5869), "SPLAI TURN", "PE SP. INDEPENDENTEI, LA INTERSECTIA CU BD. NATIUNILE UNITE", 5m, 44 },
                    { 329, 14, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5910), "SPLAIUL INDEPENDENTEI 3", "INTRE STR. GRADINA CU CAI SI STR. B.P.HASDEU", 5m, 14 },
                    { 330, 23, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5953), "SPLAIUL INDEPENDENTEI 4", "INTRE BD. SCHITU MAGUREANU SI GRADINA CU CAI", 5m, 23 },
                    { 331, 23, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5994), "SPLAIUL INDEPENDENTEI 5", "INTRE STR. ILFOV SI STR. MIHAI VODA", 5m, 23 },
                    { 332, 20, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6037), "SPLAIUL INDEPENDENTEI 6", "INTRE CALEA VICTORIEI SI STR. ILFOV", 5m, 20 },
                    { 333, 167, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6078), "SPLAIUL UNIRII", "INTRE STR. D. CANTEMIR SI BD. MARASESTI", 5m, 167 },
                    { 334, 322, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6123), "STEFAN CEL MARE 1", "INTRE BUCUR OBOR SI VASILE LASCAR", 2.5m, 322 },
                    { 335, 260, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6166), "STEFAN CEL MARE 2", "INTRE VASILE LASCAR SI CALEA FLOREASCA", 2.5m, 260 },
                    { 336, 38, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6211), "TAKE IONESCU", "INTRE BD. GHE. MAGHERU SI STR. MENDELEEV", 5m, 38 },
                    { 323, 42, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5612), "SLANIC", "", 10m, 42 },
                    { 337, 14, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6253), "TERASA SIDNEY", "INTRE CALEA VICTORIEI SI LASCAR CATARGIU", 5m, 14 },
                    { 339, 36, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6337), "THOMAS MASARYK", "INTRE STR. VASILE LASCAR SI STR. J.L. CALDERON", 5m, 36 },
                    { 340, 41, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6379), "TONITZA", "ZONA DELIMITATA DE STR. NICOLAE TONITZA, STR. FILITTI SI SP. INDEPENDENTEI", 10m, 41 },
                    { 341, 14, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6460), "TRAIAN", "INTRE STR. PLANTELOR SI STR. ST. MIHAILEANU", 5m, 14 },
                    { 342, 32, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6510), "TRAIAN VUIA", "INTRE BD. N. BALCESCU SI STR. VASILE CONTA", 10m, 32 },
                    { 343, 125, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6555), "TUDOR ARGHEZI", "", 10m, 125 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 344, 20, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6601), "UDRISTE – STRADA", "PE STR. MATEI BASARAB, INTRE BD. CORNELIU COPOSU SI BD. MIRCEA VODA", 5m, 20 },
                    { 345, 30, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6645), "UNIREA PANTA", "BD. CORNELIU COPOSU, INTRE BD. I.C.BRATIANU SI STR. SF. VINERI", 10m, 30 },
                    { 346, 14, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6688), "UNIREA PASAJ", "BD. I.C.BRATIANU", 10m, 14 },
                    { 347, 211, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6731), "UNIRII", "BD. UNIRII (PTA. CONSTITUTIEI - PTA. UNIRII)", 5m, 211 },
                    { 348, 171, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6777), "BD. UNIRII – ALVEOLA 1D", "INTRE PIATA UNIRII SI MIRCEA VODA", 10m, 171 },
                    { 349, 247, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6821), "BD. UNIRII – ALVEOLA 1S", "INTRE PTA UNIRII SI MIRCEA VODA", 10m, 247 },
                    { 350, 34, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6865), "BD. UNIRII – ALVEOLA 2D", "INTRE MIRCEA VODA SI NERVA TRAIAN", 5m, 34 },
                    { 351, 124, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6908), "BD. UNIRII – ALVEOLA 2S", "INTRE MIRCEA VODA SI BD. UNIRII TRONSON S3", 5m, 124 },
                    { 338, 56, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6295), "TERASA SIDNEY 2", "INTRE CALEA VICTORIEI SI STR. BUZESTI", 5m, 56 },
                    { 228, 19, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1320), "ION BREZOIANU 2", "INTRE LIPSCANI SI DOMNITA ANASTASIA", 5m, 19 },
                    { 322, 29, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5572), "SILFIDELOR", "", 5m, 29 },
                    { 320, 82, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5485), "SFINTII APOSTOLI", "", 5m, 82 },
                    { 292, 10, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4186), "PIATA VICTORIEI SPRING TIME", "PTA. VICTORIEI", 5m, 10 },
                    { 293, 127, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4272), "PIATA WALTER MARACINEANU", "", 5m, 127 },
                    { 294, 52, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4318), "PITAR MOS", "INTRE C.A.ROSETTI SI J.MICHELET", 5m, 52 },
                    { 295, 27, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4361), "POIANA NARCISELOR 1", "INTRE STR. I.CAMPINEANU SI STR. I.BREZOIANU", 5m, 27 },
                    { 296, 40, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4404), "POIANA NARCISELOR 2", "INTRE STR. STIRBEI VODA SI STR. VASILE SION", 5m, 40 },
                    { 297, 23, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4446), "POLIZU", "INTRE STR. DR. VARNALI SI STR. IACOB FELIX", 5m, 23 },
                    { 298, 79, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4490), "POLONA 1", "INTRE ION BOGDAN SI BROSTEANU", 5m, 79 },
                    { 299, 49, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4528), "POLONA 2", "INTRE ION BOGDAN SI STEFAN CEL MARE", 5m, 49 },
                    { 300, 41, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4570), "POMPILIU ELIADE", "INTRE PTA. M. KOGALNICEANU SI STR. SF. CONSTANTIN", 5m, 41 },
                    { 301, 160, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4610), "POPA TATU", "INTRE STR. STIRBEI VODA SI STR. BERZEI", 5m, 160 },
                    { 302, 15, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4652), "POSTA VITAN 1", "INTRE STR. O.GOGA SI CALEA VITAN", 2.5m, 15 },
                    { 303, 208, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4694), "PIATA ALBA IULIA", "ROND PTA. ALBA IULIA", 2.5m, 208 },
                    { 304, 23, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4739), "PIATA LAHOVARI", "PIATA LAHOVARI", 5m, 23 },
                    { 321, 13, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5528), "SFINTII VOIEVOZI", "LA INTERSECTIA STR. SF. VOIEVOZI SI MIHAIL MOXA", 5m, 13 },
                    { 305, 527, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4779), "PIATA PRESEI LIBERE", "ALEILE INCONJURATOARE CASA PRESEI", 2.5m, 527 },
                    { 307, 24, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4863), "RAUREANU", "INTRE CALEA VICTORIEI SI SPLAIUL INDEPENDENTEI", 5m, 24 },
                    { 308, 16, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4904), "REGINA ELISABETA", "BD. REGINA ELISABETA", 5m, 16 },
                    { 309, 25, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5007), "RIGAS", "INTRE STR. BREZOIANU SI PARC CISMIGIU", 5m, 25 },
                    { 310, 25, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5057), "ROND PESCARUS", "ALVEOLA PARC HERASTRAU (BD. AVIATORILOR - BD. BEIJING)", 5m, 25 },
                    { 311, 26, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5100), "ROSETTI SEMAFOR", "INTRE PRAPORGESCU SI J.L.CALDERON", 10m, 26 },
                    { 312, 166, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5143), "SALA PALATULUI", "ALEILE DIN JURUL SALII PALATULUI", 5m, 166 },
                    { 313, 140, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5186), "SCHITU MAGUREANU", "BD. SCHITU MAGUREANU", 5m, 140 },
                    { 314, 24, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5230), "SCHITU MAGUREANU 2", "BD. SCHITU MAGUREANU", 5m, 24 },
                    { 315, 4, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5271), "SCOALEI", "", 10m, 4 },
                    { 316, 110, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5315), "SEVASTOPOL", "", 5m, 110 },
                    { 317, 117, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5357), "SFANTA VINERI (STRADAL)", "INTRE BD. MIRCEA VODA SI STR. MAMULARI", 5m, 117 },
                    { 318, 160, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5400), "SFANTA VINERI 2", "ADICENT BD. MIRCEA VODA", 5m, 160 },
                    { 319, 45, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(5442), "SFANTUL CONSTANTIN", "INTRE STR. POMPILIU ELIADE SI CALEA PLEVNEI", 5m, 45 },
                    { 306, 108, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(4822), "RADU BELLER", "STR. AV. RADU BELLER", 2.5m, 108 },
                    { 227, 47, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1279), "ION BREZOIANU", "INTRE BD. REGINA ELISABETA SI INTR. RIGAS", 5m, 47 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 226, 12, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1240), "IANCU DE HUNEDOARA 2", "INTRE INTR. GENEVA SI STR. CLOPOTARII VECHI", 5m, 12 },
                    { 225, 36, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1199), "IANCU DE HUNEDOARA 1", "INTRE BD. LASCAR CATARGIU SI INTR. GENEVA", 5m, 36 },
                    { 133, 198, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6989), "BUCUR OBOR", "PE STR. HALELE OBOR", 2.5m, 198 },
                    { 134, 25, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7034), "C.A. ROSETTI", "INTRE BD. N. BALCESCU SI STR. T. ARGHEZI", 5m, 25 },
                    { 135, 94, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7075), "CADEREA BASTILIEI 1", "INTRE BD. LASCAR CATARGIU SI STR. I. SLATINEANU", 5m, 94 },
                    { 136, 57, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7115), "CADEREA BASTILIEI 2", "INTRE BD. I. SLATINEANU SI BD. IANCU DE HUNEDOARA", 5m, 57 },
                    { 137, 125, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7155), "CALEA FLOREASCA 1", "INTRE SOS. STEFAN CEL MARE SI STR. TUDOR VIANU", 2.5m, 125 },
                    { 138, 44, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7242), "CALEA FLOREASCA 2", "INTRE STR. TUDOR VIANU SI STR. BALANESCU ROSETTI", 2.5m, 44 },
                    { 139, 63, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7286), "CALEA FLOREASCA 3", "INTRE STR. BALANESCU ROSETTI SI STR. MIHAIL GLINKA", 2.5m, 63 },
                    { 140, 36, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7328), "CALEA FLOREASCA 4", "INTRE STR. MIHAIL GLINKA SI STR. CEAIKOVSKI", 2.5m, 36 },
                    { 141, 53, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7369), "CALEA FLOREASCA 5", "INTRE STR. CEAIKOVSKI SI STR. ANCUTA BANEASA", 2.5m, 53 },
                    { 142, 34, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7410), "CALEA GRIVITEI 1", "INTRE PASAJ BASARAB SI VASILE STR. TARUSANU", 2.5m, 34 },
                    { 143, 71, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7450), "CALEA GRIVITEI 2", "INTRE STR. POLIZU SI STR. SF. VOIEVOZI", 5m, 71 },
                    { 144, 40, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7492), "CALEA GRIVITEI 3", "INTRE STR. SF. VOIEVOZI SI BD. DACIA", 5m, 40 },
                    { 145, 61, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7533), "CALEA GRIVITEI 4", "INTRE BD. DACIA SI CALEA VICTORIEI", 5m, 61 },
                    { 132, 49, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6948), "BOTEANU", "INTRE STR. C.A. ROSETTI SI STR. D.I. DOBRESCU", 5m, 49 },
                    { 146, 15, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7574), "CALEA MOSILOR", "INTRE STR. BARATIEI SI STR. SF. VINERI", 10m, 15 },
                    { 148, 85, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7676), "CALEA PLEVNEI 1", "INTRE PTA. M.KOGALNICEANU SI STR. SF.CONSTANTIN", 5m, 85 },
                    { 149, 76, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7717), "CALEA PLEVNEI 2", "INTRE STR. BERZEI SI STR. STIRBEI VODA", 2.5m, 76 },
                    { 150, 27, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7759), "CALEA PLEVNEI 3", "INTRE STR. MIRCEA VULCANESCU SI STR. WITING", 2.5m, 27 },
                    { 151, 52, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7800), "CALEA PLEVNEI 4", "INTRE STR. WITING SI STR. PISONI", 2.5m, 52 },
                    { 152, 48, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7841), "CALEA PLEVNEI 5", "INTRE STR. PISONI SI STR. BARIEREI", 2.5m, 48 },
                    { 153, 12, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7882), "CALEA PLEVNEI 6", "INTRE STR. BARIEREI SI STR. AFLUENTULUI", 2.5m, 12 },
                    { 154, 107, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7968), "CALEA RAHOVEI", "INTRE BD. LIBERTATII SI STR. SABINELOR", 2.5m, 107 },
                    { 155, 14, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8014), "CALEA VICTORIEI 1", "INTRE PTA. VICTORIEI SI STR. SEVASTOPOL", 5m, 14 },
                    { 156, 31, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8056), "CALEA VICTORIEI 2", "INTRE CALEA GRIVITEI SI STR. BANULUI", 5m, 31 },
                    { 157, 475, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8095), "CANDIANO POPESCU", "INTRE PTA. LIBERTATII SI CALEA SERBAN VODA", 2.5m, 475 },
                    { 158, 20, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8138), "CEC BANCOREX", "STR. MIHAI VODA, INTRE CALEA VICTORIEI SI STR. ILFOV", 5m, 20 },
                    { 159, 60, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8178), "CEC JUDECATORIE", "STR. ILFOV, INTRE SPLAI INDEP. SI STR. MIHAI VODA", 5m, 60 },
                    { 160, 30, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8218), "CEC MARCONI", "STR. MARCONI, INTRE C.VICTORIEI SI STR. ILFOV", 5m, 30 },
                    { 147, 33, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(7614), "CALEA PLEVNEI", "CALEA PLEVNEI", 5m, 33 },
                    { 161, 138, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8258), "CHIRISTIGIILOR", "STR. CHIRISTIGIILOR, CF. AVIZ CTC NR. 11987/05.08.2010", 2.5m, 138 },
                    { 131, 82, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6904), "BISERICA ENEI", "INTRE STR. ACADEMIEI SI STR. EDGAR QUINET", 10m, 82 },
                    { 129, 89, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6786), "GENERAL BERTHELOT 3", "INTRE STR. POPA TATU SI STR. BERZEI", 5m, 89 },
                    { 101, 29, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(4909), "Alee Legatura Banu Antonache si Calea Floreasca", "", 2.5m, 29 },
                    { 102, 8, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5115), "ALEEA CAUZASI", "INTERSECTIA CU BD. MIRCEA VODA", 5m, 8 },
                    { 103, 59, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5178), "ALEEA PRIVIGHETORILOR 1", "INTRE AL.PRIVIGHETORILOR SI SERBAN CANTACUZINO", 2.5m, 59 },
                    { 104, 56, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5226), "ALEXANDRU BELDIMAN", "INTRE BD. REGINA ELISABETA SI STR. EFORIE", 5m, 56 },
                    { 105, 153, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5303), "ALEXANDRU CONSTANTINESCU", "INTRE BD. MARASESTI SI BD. ION MIHALACHE", 2.5m, 153 },
                    { 106, 57, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5352), "ALEXANDRU IOAN CUZA 1", "INTRE GH. DUCA SI DR. I. FELIX", 5m, 57 },
                    { 107, 47, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5448), "ALEXANDRU IOAN CUZA 2", "INTRE GH. DUCA SI C-TIN DISESCU", 5m, 47 },
                    { 108, 76, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5505), "ALEXANDRU IOAN CUZA 3", "INTRE SOS. N.TITULESCU SI STR. C-TIN DISESCU", 5m, 76 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 109, 7, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5597), "ARISTIDE DEMETRIADE", "INTRE STR. BREZOIANU SI STR. GEORGE VRACA", 5m, 7 },
                    { 110, 41, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5667), "PICTOR ARTHUR VERONA", "STR. PICTOR VERONA, INTRE BD. MAGHERU SI STR. PITAR MOS", 5m, 41 },
                    { 111, 70, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5709), "ARTHUR VERONA 2", "INTRE PITAR MOS SI J.L.CALDERON", 5m, 70 },
                    { 112, 223, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5750), "AVIATORILOR 1D", "INTRE ROND PESCARUS SI PIATA CHARLES DE GAULLE", 5m, 223 },
                    { 113, 181, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5790), "AVIATORILOR 1S", "INTRE ROND PESCARUS SI PIATA CHARLES DE GAULLE", 5m, 181 },
                    { 130, 59, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6861), "BIBESCU VODA", "INTRE SP. INDEPENDENTEI SI BD. D. CANTEMIR", 5m, 59 },
                    { 114, 175, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5889), "AVIATORILOR 2D", "INTRE PIATA CHARLES DE GAULLE SI GH. DEMETRIADE", 5m, 175 },
                    { 116, 85, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5975), "AVIATORILOR 3S", "INTRE PIATA VICTORIEI SI STR. CAPITAN GHE. DEMETRIADE", 5m, 85 },
                    { 117, 145, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6016), "AVRIG 1", "INTRE BD. FERDINAND SI STR. CHIRISTIGIILOR", 2.5m, 145 },
                    { 118, 159, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6060), "AVRIG 2", "INTRE SOS. IANCULUI SI STR. RITMULUI", 2.5m, 159 },
                    { 119, 23, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6103), "BALANESCU ROSETTI", "INTRE CALEA FLOREASCA SI STR. BANUL ANTONACHE", 2.5m, 23 },
                    { 120, 65, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6173), "BANU MANTA 1", "INTRE STR. G-RAL VLADOIANU BARBU SI STR. FROSA SARANDY", 2.5m, 65 },
                    { 121, 65, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6217), "BANU MANTA 2", "INTRE STR. FROSA SARANDY SI BD. I. MIHALACHE", 2.5m, 65 },
                    { 122, 126, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6258), "BANUL ANTONACHE", "", 2.5m, 126 },
                    { 123, 68, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6345), "BARBU DELAVRANCEA", "INTRE BD. ION MIHALACHE SI STR. ION MINCU", 5m, 68 },
                    { 124, 495, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6389), "BASARABIA 1", "INTRE PIATA MUNCII SI BD. CHISINAU", 2.5m, 495 },
                    { 125, 58, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6435), "BATISTEI", "INTRE BD. NICOLAE BALCESCU SI STR. I.L.CARAGIALE", 10m, 58 },
                    { 126, 22, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6478), "BCU – BIBLIOTECA CENTRALA UNIVERSITARA", "STR. DEM. I. DOBRESCU, INTRE CALEA VICTORIEI SI STR. BOTEANU", 5m, 22 },
                    { 127, 36, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6518), "GENERAL BERTHELOT", "INTRE STR. L.CAZAVILLIAN SI STR. POPA TATU", 5m, 36 },
                    { 128, 57, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(6567), "GENERAL BERTHELOT 2", "INTRE STR. LUTERANA SI CALEA VICTORIEI", 5m, 57 },
                    { 115, 181, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(5933), "AVIATORILOR 2S", "INTRE PTA CHARLES DE GAULLE SI STR. GH. DEMETRIADE", 5m, 181 },
                    { 352, 12, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(6951), "CONSTANTIN ESARCU", "INTRE STR. EPISCOPIEI SI STR. NICOLAE GOLESCU", 5m, 12 },
                    { 162, 21, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8299), "CHRISTIAN TELL", "INTRE STR. BISERICA AMZEI SI PIATA AMZEI", 5m, 21 },
                    { 164, 72, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8383), "CINA 2", "INTRE STR. B. FRANKLIN SI STR. EPISCOPIEI", 5m, 72 },
                    { 197, 93, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9867), "FICUSULUI 2", "INTRE STR. H.MACELARIU SI BD. AEROGARII", 2.5m, 93 },
                    { 198, 152, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9907), "FRUMOASA", "INTRE CALEA VICTORIEI SI STR. SEVASTOPOL", 5m, 152 },
                    { 199, 119, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9947), "GARA BANEASA", "ESPLANADA GARII BANEASA SI STR. TIPOGRAFILOR", 5m, 119 },
                    { 200, 13, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(99), "GARA CEAS", "PIATA GARII DE NORD", 5m, 13 },
                    { 201, 39, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(156), "GARA PARC", "PIATA GARII DE NORD", 5m, 39 },
                    { 202, 25, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(199), "GARII DE NORD 1", "STR. GARII DE NORD, INTRE STR. BERZEI SI STR. CAMELIEI", 2.5m, 25 },
                    { 203, 77, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(239), "GARII DE NORD 2", "STR. GARII DE NORD, INTRE STR. CAMELIEI SI PTA. GARII DE NORD", 2.5m, 77 },
                    { 204, 147, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(282), "GEORGE CALINESCU", "", 2.5m, 147 },
                    { 205, 35, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(326), "GEORGE ENESCU", "STR. GEORGE ENESCU, INTRE STR. MENDELEEV SI BD. MAGHERU", 5m, 35 },
                    { 206, 65, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(368), "GEORGE ENESCU 3", "INTRE STR. D.I.MENDELEEV SI CALEA VICTORIEI", 5m, 65 },
                    { 207, 54, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(408), "GHEORGHE DUCA", "INTRE CALEA GRIVITEI SI A.I.CUZA", 2.5m, 54 },
                    { 208, 46, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(450), "GHEORGHE LAZAR", "INTRE SF. CONSTANTIN SI GH.COBALCESCU", 2.5m, 46 },
                    { 209, 31, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(490), "GRADINA CU CAI", "INTRE SP. INDEPENDENTEI SI PTA. M.KOGALNICEANU", 5m, 31 },
                    { 196, 46, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9827), "FICUSULUI 1", "INTRE STR. E.VACARESCU SI STR. H.MACELARIU", 2.5m, 46 },
                    { 210, 30, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(532), "GRADINITA – ROSETTI", "STR. C.A.ROSETTI, INTRE STR. T. ARGHEZI SI STR. DAVID PRAPORGESCU", 10m, 30 },
                    { 212, 216, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(616), "GRIGORE ALEXANDRESCU 2", "INTRE BD. LASCAR CATARGIU SI CALEA DOROBANTI", 5m, 216 },
                    { 213, 118, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(657), "GRIGORE COBALCESCU", "INTRE BD. SCHITU MAGUREANU SI STR. BERZEI", 5m, 118 },
                    { 214, 82, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(698), "GUTENBERG", "", 2.5m, 82 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 215, 15, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(739), "HALELOR", "STR. HALELOR, INTRE STR. SELARI SI STR. CALDARARI", 10m, 15 },
                    { 216, 99, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(821), "HERASTRAU 1 (PAVILION H)", "PARC HERASTRAU", 5m, 99 },
                    { 217, 132, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(868), "HERASTRAU 2 BOA", "PARC MIORITA (HERASTRAU)", 5m, 132 },
                    { 218, 14, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(911), "HOROSCOP 1", "BD. D. CANTEMIR - INTRE SPLAIUL UNIRII SI STR. BIBESCU VODA", 5m, 14 },
                    { 219, 11, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(951), "HOROSCOP 2 SITRACO", "BD. D. CANTEMIR - INTRE SPLAIUL UNIRII SI STR. BIBESCU VODA", 5m, 11 },
                    { 220, 24, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(996), "HOROSCOP 3 SPLAI", "BD. D. CANTEMIR - SPLAIUL UNIRII", 5m, 24 },
                    { 221, 20, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1036), "HRISTO BOTEV 1", "INTRE STR. SCAUNE SI STR. IVO ANDRIC", 5m, 20 },
                    { 222, 25, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1078), "HRISTO BOTEV 2", "INTRE STR. NEGUSTORI SI STR. TEODOR STEFANESCU", 5m, 25 },
                    { 223, 91, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1117), "IACOB FELIX 1", "INTRE STR. GHE. POLIZU SI SOS. N. TITULESCU", 2.5m, 91 },
                    { 224, 33, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(1159), "IACOB FELIX 2", "INTRE SOS. N. TITULESCU SI BD. I. MIHALACHE", 2.5m, 33 },
                    { 211, 41, "București", new DateTime(2021, 7, 13, 23, 46, 48, 51, DateTimeKind.Local).AddTicks(573), "GRIGORE ALEXANDRESCU", "STR. GRIGORE ALEXANDRESCU, INTRE CALEA VICTORIEI SI BD. LASCAR CATARGIU", 5m, 41 },
                    { 163, 126, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8338), "CINA", "INTRE STR. C.A. ROSETTI SI STR. B. FRANKLIN", 5m, 126 },
                    { 195, 188, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9785), "EXPOZITIEI", "BD. EXPOZITIEI (ZONA ROMEXPO)", 5m, 188 },
                    { 193, 77, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9705), "EPISCOPIEI", "INTRE N.GOLESCU SI C. VICTORIEI", 5m, 77 },
                    { 165, 35, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8427), "CLOPOTARII VECHI", "INTRE STR. GRIGORE ALEXANDRESCU SI BD. IANCU DE HUNEDOARA", 5m, 35 },
                    { 166, 54, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8469), "CONSERVATOR – UNESCO", "STR. STIRBEI VODA", 5m, 54 },
                    { 167, 84, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8509), "CONSTANTIN MILLE", "INTRE CALEA VICTORIEI SI STR. I. BREZOIANU", 5m, 84 },
                    { 168, 33, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8591), "CONSTANTIN NACU", "INTRE PTA. ITALIANA SI BD. CAROL I", 5m, 33 },
                    { 169, 92, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8636), "CRANGASI", "PTA. CRANGASI", 2.5m, 92 },
                    { 170, 36, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8678), "CRETULESCU", "ALEEA DE LANGA BISERICA CRETULESCU", 5m, 36 },
                    { 171, 40, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8718), "DACIA 2", "BD. DACIA", 5m, 40 },
                    { 172, 21, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8759), "DACIA MONTEORU", "BD. DACIA X CALEA VICTORIEI", 5m, 21 },
                    { 173, 69, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8798), "DANIELOPOL", "INTRE SPLAIUL INDEPENDENTEI SI STR. POENARU BORDEA", 5m, 69 },
                    { 174, 64, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8839), "DECEBAL 1", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 64 },
                    { 175, 44, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8879), "DECEBAL 2", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 44 },
                    { 176, 53, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8922), "DECEBAL 3", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 53 },
                    { 177, 67, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(8963), "DIANEI", "INTRE ITALIANA SI CAROL I", 5m, 67 },
                    { 194, 73, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9746), "EVA", "BD. GHE. MAGHERU, INTRE STR. G.ENESCU SI STR. ANASTASIE SIMU", 5m, 73 },
                    { 178, 72, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9004), "DINICU GOLESCU (GARA)", "", 2.5m, 72 },
                    { 180, 120, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9087), "DIONISIE LUPU", "INTRE STR. G-RAL EREMIA GRIGORESCU SI C.A.ROSETTI", 5m, 120 },
                    { 181, 18, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9128), "DOAMNEI 1", "STR. DOAMNEI, INTRE BD. I.C.BRATIANU SI INTR. SELARI", 10m, 18 },
                    { 182, 21, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9169), "DOAMNEI 2", "", 10m, 21 },
                    { 183, 28, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9210), "DOAMNEI 4", "", 10m, 28 },
                    { 184, 57, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9329), "DOMNITA ANASTASIA", "INTRE STR. LIPSCANI SI STR. A. SALIGNY", 5m, 57 },
                    { 185, 21, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9378), "DOROBANTI", "PTA. DOROBANTI", 5m, 21 },
                    { 186, 11, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9419), "DOROBANTI – LAHOVARI", "", 5m, 11 },
                    { 187, 11, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9459), "DOROBANTI DACIA", "INTERSECTIE BD. DACIA SI CALEA DOROBANTILOR", 5m, 11 },
                    { 188, 19, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9500), "DRISTOR 1", "INTRE C.RESSU SI STATIE METROU", 2.5m, 19 },
                    { 189, 21, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9541), "DRISTOR 2", "INTRE STATIE METROU SI GRAULUI", 2.5m, 21 },
                    { 190, 107, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9582), "EDGAR QUINET", "INTRE CALEA VICTORIEI SI BISERICA ENEI", 10m, 107 },
                    { 191, 48, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9623), "EFORIE", "INTRE C.VICTORIEI SI STR. D. ANASTASIA", 5m, 48 },
                    { 192, 64, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9664), "ELENA VACARESCU", "INTRE BD. FICUSULUI SI SOS. BUCURESTI-PLOIESTI", 2.5m, 64 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[] { 179, 111, "București", new DateTime(2021, 7, 13, 23, 46, 48, 50, DateTimeKind.Local).AddTicks(9043), "DINICU GOLESCU 1", "INTRE STR. M. VULCANESCU SI PTA. GARII DE NORD", 2.5m, 111 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 1, new DateTime(2021, 7, 13, 23, 46, 47, 794, DateTimeKind.Local).AddTicks(2115), "administrator220@easypark.com", "ADMINISTRATOR", "$2a$11$.NgBUXaPBVvFN/xldziX.ulbEtWgnoR9z6//6ArZjkJqNim4gH4vK", "0723678956", 220 });

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
                unique: true,
                filter: "[LicenseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_UserId",
                table: "Drivers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ParkingAreaId",
                table: "Reservations",
                column: "ParkingAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VehicleId",
                table: "Reservations",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles",
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
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "DrivingLicense");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
