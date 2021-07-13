using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingApp.Main.DataAcces.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 100, 96, "București", new DateTime(2021, 7, 14, 1, 38, 30, 885, DateTimeKind.Local).AddTicks(8984), "Academiei", "Între bd. Regina Elisabeta și I. Campineanu", 10m, 96 },
                    { 262, 98, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2483), "NICOLAE FILIPESCU", "INTRE STR. C.A. ROSETTI SI STR. BATISTEI", 10m, 98 },
                    { 263, 32, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2525), "NICOLAE GOLESCU", "INTRE STR. G. ENESCU SI STR. EPISCOPIEI", 5m, 32 },
                    { 264, 35, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2570), "NICOLAE IORGA", "INTRE CALEA VICTORIEI SI STR. HENRI COANDA", 5m, 35 },
                    { 265, 35, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2610), "NICOLAE TITULESCU", "INTRE INTR. COJESTI SI STR. DR. IACOB FELIX", 2.5m, 35 },
                    { 266, 163, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2651), "OCTAVIAN GOGA 1", "INTRE CALEA DUDESTI SI STR. NERVA TRAIAN", 2.5m, 163 },
                    { 267, 18, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2689), "OCTAVIAN GOGA 3", "ARTERA DREAPTA PASAJ MARASESTI", 5m, 18 },
                    { 268, 138, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2735), "OCTAVIAN GOGA 4", "DEASUPRA PASAJ MARASESTI", 5m, 138 },
                    { 269, 50, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2776), "OCTAVIAN GOGA 5", "DEASUPRA PASAJ MARASESTI - DREAPTA PARCAJ GOGA 4", 5m, 50 },
                    { 270, 80, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2816), "OPERA", "PTA. VICTOR BABES", 5m, 80 },
                    { 271, 12, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2855), "ORIZONT", "INTR. JEAN GEORGESCU, LA INTERSECTIA CU STR. DEM I. DOBRESCU", 10m, 12 },
                    { 272, 28, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2897), "OTETELESANU", "INTRE STR. MATEI MILLO SI STR. C-TIN MILLE", 5m, 28 },
                    { 273, 11, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2937), "PANIPAT", "BD. BRATIANU", 10m, 11 },
                    { 274, 266, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2977), "PANTELIMON 1S", "SOS. MORARILOR - SOS. VERGULUI", 2m, 266 },
                    { 275, 61, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3016), "PECO ANGHEL SALIGNY", "STR. ANGHEL SALIGNY", 5m, 61 },
                    { 276, 72, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3057), "PECO BARIERE", "SP. INDEPENDENTEI, INTRE STR. A. SALIGNY SI ELIE RADU", 5m, 72 },
                    { 277, 25, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3096), "PECO M.I.", "INTERSECTIE A. SALIGNY - LIPSCANI", 5m, 25 },
                    { 278, 13, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3191), "PECO POMPIERI", "INTRE STR. A. SALIGNY SI ELIE RADU", 5m, 13 },
                    { 279, 99, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3232), "PESCARUS", "ALEEA DE ACCES IN PARCUL HERASTRAU - LA RESTAURANTUL PESCARUS", 5m, 99 },
                    { 280, 80, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3273), "PIATA ALBA IULIA 1", "INTRE BD. UNIRII SI BD. DECEBAL (ALVEOLE)", 2.5m, 80 },
                    { 281, 77, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3314), "PIATA AMZEI 1", "INTRE CALEA VICTORIEI SI STR. MENDELEEV", 5m, 77 },
                    { 282, 65, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3352), "PIATA AMZEI 2", "INTRE STR. BISERICA AMZEI SI PIATA AMZEI", 5m, 65 },
                    { 283, 47, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3391), "PIATA AMZEI 3", "INTRE STR. CHRISTIAN TELL SI PIATA AMZEI", 5m, 47 },
                    { 284, 37, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3432), "PIATA CHARLES DE GAULLE", "ALVEOLE PARTEA DREAPTA P-TA CH. DE GAULLE (BD. PREZAN)", 5m, 37 },
                    { 285, 494, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3471), "PIATA CONSTITUTIEI", "PIATA CONSTITUTIEI - PASTILA (FARA ALVEOLE)", 5m, 494 },
                    { 286, 25, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3512), "PIATA GEMENI", "PIATA GEMENI", 5m, 25 },
                    { 287, 19, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3552), "PIATA ITALIANA", "ITALIANA X STR. V. LASCAR X STR. C-TIN NACU", 5m, 19 },
                    { 288, 90, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3592), "PIATA LIBERTATII 1", "INTRE STR. C-TIN ISTRATI SI BD. MARASESTI (PARCUL CAROL)", 5m, 90 },
                    { 261, 156, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2428), "NICOLAE CARAMFIL", "BD. NICOLAE CARANFIL", 10m, 156 },
                    { 260, 24, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2304), "NICOLAE BALCESCU 2", "INTRE STR. C.A. ROSETTI SI STR. DEM. I. DOBRESCU", 10m, 24 },
                    { 259, 44, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2261), "NICOLAE BALCESCU 1", "INTRE STR. DEM. I. DOBRESCU SI STR. I. CAMPINEANU", 10m, 44 },
                    { 258, 35, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2222), "NERVA TRAIAN", "", 5m, 35 },
                    { 230, 73, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1046), "ION CAMPINEANU", "INTRE CALEA VICTORIEI SI BD. N. BALCESCU", 10m, 73 },
                    { 231, 45, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1086), "ION CAMPINEANU (SUPERB)", "INTRE STR. STIRBEI VODA SI STR. W. MARACINEANU", 5m, 45 },
                    { 232, 57, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1128), "ION CAMPINEANU 1", "INTRE W.MARACINEANU SI CALEA VICTORIEI", 5m, 57 },
                    { 233, 24, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1168), "ION GHICA", "INTRE I.C.BRATIANU SI DOAMNEI", 10m, 24 },
                    { 234, 46, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1212), "JEAN LOUIS CALDERON 1", "INTRE ITALIANA SI C.A.ROSETTI", 10m, 46 },
                    { 235, 18, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1250), "JEAN LOUIS CALDERON 2", "INTRE C.A.ROSETTI SI ITALIANA", 10m, 18 },
                    { 236, 49, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1291), "JEAN LOUIS CALDERON 3", "INTRE ICOANEI SI PTA CANTACUZINO", 10m, 49 },
                    { 237, 84, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1332), "KISELEFF ALVEOLA", "INTRE MONETARIEI SI ION MINCU", 5m, 84 },
                    { 238, 15, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1373), "LASCAR CATARGIU – HOTEL MINERVA", "INTRE STR. H. COANDA SI STR. G-RAL GHE. MANU", 5m, 15 },
                    { 239, 44, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1412), "LIBERTATII", "INTRE BD. NATIUNILE UNITE SI SPLAIUL INDEPENDENTEI, PE PARTE ADIACENTA PARCULUI", 5m, 44 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 240, 11, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1453), "LIDO", "INTRE STR. ANASTASIE SINU SI STR. B. FRANKLIN", 5m, 11 },
                    { 241, 60, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1494), "LIDO TERASA", "INTRE CALEA VICTORIEI SI BD. MAGHERU", 5m, 60 },
                    { 242, 27, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1534), "LIPSCANI 1", "INTRE STR. A.SALIGNY SI STR. I.BREZOIANU", 5m, 27 },
                    { 289, 18, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3634), "PIATA LIBERTATII 2", "INTRE BD. MARASESTI SI STR. 11 IUNIE", 5m, 18 },
                    { 243, 30, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1573), "LIPSCANI 2", "INTRE BD. I.C. BRATIANU SI CALEA MOSILOR", 5m, 30 },
                    { 245, 29, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1694), "MAGAZIN VICTORIA", "MAGAZIN VICTORIA", 5m, 29 },
                    { 246, 62, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1741), "MARIA ROSETTI", "INTRE STR ION LUCA CARAGIALE SI STR. SF SPIRIDON", 5m, 62 },
                    { 247, 43, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1780), "MARRIOTT", "ZONA PTA. ARSENALULUI", 5m, 43 },
                    { 248, 31, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1820), "MATEI BASARAB 1", "INTRE STR. MIRCEA VODA SI BD. CORNELIU COPOSU", 10m, 31 },
                    { 249, 55, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1862), "MATEI MILLO", "INTRE CALEA VICTORIEI SI STR. G. VRACA", 5m, 55 },
                    { 250, 113, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1902), "MENDELEEV", "STR. MENDELEEV, INTRE STR. G. ENESCU SI PTA. ROMANA", 5m, 113 },
                    { 251, 20, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1942), "MINISTERUL MEDIULUI", "BD. LIBERTATII", 5m, 20 },
                    { 252, 319, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1982), "MIRCEA VODA", "BD C. COPOSU - NERVA TRAIAN", 5m, 319 },
                    { 253, 20, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2022), "BD. MIRCEA VODA, HOTEL MERCURE", "", 5m, 20 },
                    { 254, 29, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2064), "BD. MIRCEA VODA, TIMPURI NOI", "INTERSECTIE BD. MIRCEA VODA SI STR. NERVA TRAIAN - PARC TIMPURI NOI", 5m, 29 },
                    { 255, 80, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2102), "MIRCEA VULCANESCU", "INTRE STR. D.GOLESCU SI CALEA PLEVNEI", 5m, 80 },
                    { 256, 88, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2143), "MIRCEA VULCANESCU 1", "INTRE CALEA GRIVITEI SI STR. HORATIU", 5m, 88 },
                    { 257, 29, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(2182), "NATIUNILE UNITE", "INTRE PTA. NATIUNILE UNITE SI STR. SF. APOSTOLI", 10m, 29 },
                    { 244, 53, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1614), "LUTERANA", "INTRE STR. STIRBEI VODA SI STR. G-RAL BERTHELOT", 5m, 53 },
                    { 290, 136, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3674), "PIATA REVOLUTIEI", "INTRE STR. ION CAMPINEANU SI STR. DEM I. DOBRESCU", 5m, 136 },
                    { 291, 93, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3713), "PIATA VICTORIEI", "PTA. VICTORIEI (DEASUPRA PASAJULUI RUTIER)", 5m, 93 },
                    { 292, 10, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3773), "PIATA VICTORIEI SPRING TIME", "PTA. VICTORIEI", 5m, 10 },
                    { 325, 39, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5219), "SOS. NORDULUI – AMBASADA CHINEI", "INTRE BD. BEIJING SI ALEEA PRIPORULUI", 5m, 39 },
                    { 326, 39, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5300), "SPERANTEI", "INTRE STR. AR. CALINESCU SI CAROL I", 5m, 39 },
                    { 327, 24, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5347), "SPLAI EXIM BANK ALVEOLA", "SP. INDEPENDENTEI", 5m, 24 },
                    { 328, 44, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5390), "SPLAI TURN", "PE SP. INDEPENDENTEI, LA INTERSECTIA CU BD. NATIUNILE UNITE", 5m, 44 },
                    { 329, 14, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5430), "SPLAIUL INDEPENDENTEI 3", "INTRE STR. GRADINA CU CAI SI STR. B.P.HASDEU", 5m, 14 },
                    { 330, 23, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5471), "SPLAIUL INDEPENDENTEI 4", "INTRE BD. SCHITU MAGUREANU SI GRADINA CU CAI", 5m, 23 },
                    { 331, 23, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5510), "SPLAIUL INDEPENDENTEI 5", "INTRE STR. ILFOV SI STR. MIHAI VODA", 5m, 23 },
                    { 332, 20, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5553), "SPLAIUL INDEPENDENTEI 6", "INTRE CALEA VICTORIEI SI STR. ILFOV", 5m, 20 },
                    { 333, 167, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5595), "SPLAIUL UNIRII", "INTRE STR. D. CANTEMIR SI BD. MARASESTI", 5m, 167 },
                    { 334, 322, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5637), "STEFAN CEL MARE 1", "INTRE BUCUR OBOR SI VASILE LASCAR", 2.5m, 322 },
                    { 335, 260, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5678), "STEFAN CEL MARE 2", "INTRE VASILE LASCAR SI CALEA FLOREASCA", 2.5m, 260 },
                    { 336, 38, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5721), "TAKE IONESCU", "INTRE BD. GHE. MAGHERU SI STR. MENDELEEV", 5m, 38 },
                    { 337, 14, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5764), "TERASA SIDNEY", "INTRE CALEA VICTORIEI SI LASCAR CATARGIU", 5m, 14 },
                    { 324, 384, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5177), "SOS. NORDULUI", "INTRE BD. BEIJING SI STR. GRIGORE GAFENCU", 5m, 384 },
                    { 338, 56, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5804), "TERASA SIDNEY 2", "INTRE CALEA VICTORIEI SI STR. BUZESTI", 5m, 56 },
                    { 340, 41, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5885), "TONITZA", "ZONA DELIMITATA DE STR. NICOLAE TONITZA, STR. FILITTI SI SP. INDEPENDENTEI", 10m, 41 },
                    { 341, 14, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5926), "TRAIAN", "INTRE STR. PLANTELOR SI STR. ST. MIHAILEANU", 5m, 14 },
                    { 342, 32, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6008), "TRAIAN VUIA", "INTRE BD. N. BALCESCU SI STR. VASILE CONTA", 10m, 32 },
                    { 343, 125, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6056), "TUDOR ARGHEZI", "", 10m, 125 },
                    { 344, 20, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6102), "UDRISTE – STRADA", "PE STR. MATEI BASARAB, INTRE BD. CORNELIU COPOSU SI BD. MIRCEA VODA", 5m, 20 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 345, 30, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6144), "UNIREA PANTA", "BD. CORNELIU COPOSU, INTRE BD. I.C.BRATIANU SI STR. SF. VINERI", 10m, 30 },
                    { 346, 14, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6185), "UNIREA PASAJ", "BD. I.C.BRATIANU", 10m, 14 },
                    { 347, 211, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6226), "UNIRII", "BD. UNIRII (PTA. CONSTITUTIEI - PTA. UNIRII)", 5m, 211 },
                    { 348, 171, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6268), "BD. UNIRII – ALVEOLA 1D", "INTRE PIATA UNIRII SI MIRCEA VODA", 10m, 171 },
                    { 349, 247, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6309), "BD. UNIRII – ALVEOLA 1S", "INTRE PTA UNIRII SI MIRCEA VODA", 10m, 247 },
                    { 350, 34, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6352), "BD. UNIRII – ALVEOLA 2D", "INTRE MIRCEA VODA SI NERVA TRAIAN", 5m, 34 },
                    { 351, 124, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6393), "BD. UNIRII – ALVEOLA 2S", "INTRE MIRCEA VODA SI BD. UNIRII TRONSON S3", 5m, 124 },
                    { 352, 12, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(6435), "CONSTANTIN ESARCU", "INTRE STR. EPISCOPIEI SI STR. NICOLAE GOLESCU", 5m, 12 },
                    { 339, 36, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5844), "THOMAS MASARYK", "INTRE STR. VASILE LASCAR SI STR. J.L. CALDERON", 5m, 36 },
                    { 229, 52, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(1000), "ION BREZOIANU 3", "INTRE WALTER MARACINEANU SI POIANA NARCISELOR", 5m, 52 },
                    { 323, 42, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5134), "SLANIC", "", 10m, 42 },
                    { 321, 13, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5052), "SFINTII VOIEVOZI", "LA INTERSECTIA STR. SF. VOIEVOZI SI MIHAIL MOXA", 5m, 13 },
                    { 293, 127, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3815), "PIATA WALTER MARACINEANU", "", 5m, 127 },
                    { 294, 52, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3901), "PITAR MOS", "INTRE C.A.ROSETTI SI J.MICHELET", 5m, 52 },
                    { 295, 27, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3943), "POIANA NARCISELOR 1", "INTRE STR. I.CAMPINEANU SI STR. I.BREZOIANU", 5m, 27 },
                    { 296, 40, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(3984), "POIANA NARCISELOR 2", "INTRE STR. STIRBEI VODA SI STR. VASILE SION", 5m, 40 },
                    { 297, 23, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4027), "POLIZU", "INTRE STR. DR. VARNALI SI STR. IACOB FELIX", 5m, 23 },
                    { 298, 79, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4066), "POLONA 1", "INTRE ION BOGDAN SI BROSTEANU", 5m, 79 },
                    { 299, 49, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4105), "POLONA 2", "INTRE ION BOGDAN SI STEFAN CEL MARE", 5m, 49 },
                    { 300, 41, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4147), "POMPILIU ELIADE", "INTRE PTA. M. KOGALNICEANU SI STR. SF. CONSTANTIN", 5m, 41 },
                    { 301, 160, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4187), "POPA TATU", "INTRE STR. STIRBEI VODA SI STR. BERZEI", 5m, 160 },
                    { 302, 15, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4229), "POSTA VITAN 1", "INTRE STR. O.GOGA SI CALEA VITAN", 2.5m, 15 },
                    { 303, 208, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4270), "PIATA ALBA IULIA", "ROND PTA. ALBA IULIA", 2.5m, 208 },
                    { 304, 23, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4311), "PIATA LAHOVARI", "PIATA LAHOVARI", 5m, 23 },
                    { 305, 527, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4349), "PIATA PRESEI LIBERE", "ALEILE INCONJURATOARE CASA PRESEI", 2.5m, 527 },
                    { 322, 29, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5094), "SILFIDELOR", "", 5m, 29 },
                    { 306, 108, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4390), "RADU BELLER", "STR. AV. RADU BELLER", 2.5m, 108 },
                    { 308, 16, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4471), "REGINA ELISABETA", "BD. REGINA ELISABETA", 5m, 16 },
                    { 309, 25, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4511), "RIGAS", "INTRE STR. BREZOIANU SI PARC CISMIGIU", 5m, 25 },
                    { 310, 25, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4594), "ROND PESCARUS", "ALVEOLA PARC HERASTRAU (BD. AVIATORILOR - BD. BEIJING)", 5m, 25 },
                    { 311, 26, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4639), "ROSETTI SEMAFOR", "INTRE PRAPORGESCU SI J.L.CALDERON", 10m, 26 },
                    { 312, 166, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4682), "SALA PALATULUI", "ALEILE DIN JURUL SALII PALATULUI", 5m, 166 },
                    { 313, 140, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4722), "SCHITU MAGUREANU", "BD. SCHITU MAGUREANU", 5m, 140 },
                    { 314, 24, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4764), "SCHITU MAGUREANU 2", "BD. SCHITU MAGUREANU", 5m, 24 },
                    { 315, 4, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4804), "SCOALEI", "", 10m, 4 },
                    { 316, 110, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4847), "SEVASTOPOL", "", 5m, 110 },
                    { 317, 117, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4888), "SFANTA VINERI (STRADAL)", "INTRE BD. MIRCEA VODA SI STR. MAMULARI", 5m, 117 },
                    { 318, 160, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4930), "SFANTA VINERI 2", "ADICENT BD. MIRCEA VODA", 5m, 160 },
                    { 319, 45, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4970), "SFANTUL CONSTANTIN", "INTRE STR. POMPILIU ELIADE SI CALEA PLEVNEI", 5m, 45 },
                    { 320, 82, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(5011), "SFINTII APOSTOLI", "", 5m, 82 },
                    { 307, 24, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(4429), "RAUREANU", "INTRE CALEA VICTORIEI SI SPLAIUL INDEPENDENTEI", 5m, 24 },
                    { 228, 19, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(919), "ION BREZOIANU 2", "INTRE LIPSCANI SI DOMNITA ANASTASIA", 5m, 19 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 227, 47, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(876), "ION BREZOIANU", "INTRE BD. REGINA ELISABETA SI INTR. RIGAS", 5m, 47 },
                    { 163, 126, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8080), "CINA", "INTRE STR. C.A. ROSETTI SI STR. B. FRANKLIN", 5m, 126 },
                    { 135, 94, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6786), "CADEREA BASTILIEI 1", "INTRE BD. LASCAR CATARGIU SI STR. I. SLATINEANU", 5m, 94 },
                    { 136, 57, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6828), "CADEREA BASTILIEI 2", "INTRE BD. I. SLATINEANU SI BD. IANCU DE HUNEDOARA", 5m, 57 },
                    { 137, 125, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6870), "CALEA FLOREASCA 1", "INTRE SOS. STEFAN CEL MARE SI STR. TUDOR VIANU", 2.5m, 125 },
                    { 138, 44, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6910), "CALEA FLOREASCA 2", "INTRE STR. TUDOR VIANU SI STR. BALANESCU ROSETTI", 2.5m, 44 },
                    { 139, 63, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7027), "CALEA FLOREASCA 3", "INTRE STR. BALANESCU ROSETTI SI STR. MIHAIL GLINKA", 2.5m, 63 },
                    { 140, 36, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7073), "CALEA FLOREASCA 4", "INTRE STR. MIHAIL GLINKA SI STR. CEAIKOVSKI", 2.5m, 36 },
                    { 141, 53, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7112), "CALEA FLOREASCA 5", "INTRE STR. CEAIKOVSKI SI STR. ANCUTA BANEASA", 2.5m, 53 },
                    { 142, 34, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7152), "CALEA GRIVITEI 1", "INTRE PASAJ BASARAB SI VASILE STR. TARUSANU", 2.5m, 34 },
                    { 143, 71, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7190), "CALEA GRIVITEI 2", "INTRE STR. POLIZU SI STR. SF. VOIEVOZI", 5m, 71 },
                    { 144, 40, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7230), "CALEA GRIVITEI 3", "INTRE STR. SF. VOIEVOZI SI BD. DACIA", 5m, 40 },
                    { 145, 61, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7269), "CALEA GRIVITEI 4", "INTRE BD. DACIA SI CALEA VICTORIEI", 5m, 61 },
                    { 146, 15, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7307), "CALEA MOSILOR", "INTRE STR. BARATIEI SI STR. SF. VINERI", 10m, 15 },
                    { 147, 33, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7345), "CALEA PLEVNEI", "CALEA PLEVNEI", 5m, 33 },
                    { 148, 85, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7385), "CALEA PLEVNEI 1", "INTRE PTA. M.KOGALNICEANU SI STR. SF.CONSTANTIN", 5m, 85 },
                    { 149, 76, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7424), "CALEA PLEVNEI 2", "INTRE STR. BERZEI SI STR. STIRBEI VODA", 2.5m, 76 },
                    { 150, 27, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7464), "CALEA PLEVNEI 3", "INTRE STR. MIRCEA VULCANESCU SI STR. WITING", 2.5m, 27 },
                    { 151, 52, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7502), "CALEA PLEVNEI 4", "INTRE STR. WITING SI STR. PISONI", 2.5m, 52 },
                    { 152, 48, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7542), "CALEA PLEVNEI 5", "INTRE STR. PISONI SI STR. BARIEREI", 2.5m, 48 },
                    { 153, 12, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7579), "CALEA PLEVNEI 6", "INTRE STR. BARIEREI SI STR. AFLUENTULUI", 2.5m, 12 },
                    { 154, 107, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7618), "CALEA RAHOVEI", "INTRE BD. LIBERTATII SI STR. SABINELOR", 2.5m, 107 },
                    { 155, 14, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7753), "CALEA VICTORIEI 1", "INTRE PTA. VICTORIEI SI STR. SEVASTOPOL", 5m, 14 },
                    { 156, 31, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7803), "CALEA VICTORIEI 2", "INTRE CALEA GRIVITEI SI STR. BANULUI", 5m, 31 },
                    { 157, 475, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7843), "CANDIANO POPESCU", "INTRE PTA. LIBERTATII SI CALEA SERBAN VODA", 2.5m, 475 },
                    { 158, 20, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7884), "CEC BANCOREX", "STR. MIHAI VODA, INTRE CALEA VICTORIEI SI STR. ILFOV", 5m, 20 },
                    { 159, 60, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7922), "CEC JUDECATORIE", "STR. ILFOV, INTRE SPLAI INDEP. SI STR. MIHAI VODA", 5m, 60 },
                    { 160, 30, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(7961), "CEC MARCONI", "STR. MARCONI, INTRE C.VICTORIEI SI STR. ILFOV", 5m, 30 },
                    { 161, 138, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8001), "CHIRISTIGIILOR", "STR. CHIRISTIGIILOR, CF. AVIZ CTC NR. 11987/05.08.2010", 2.5m, 138 },
                    { 134, 25, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6747), "C.A. ROSETTI", "INTRE BD. N. BALCESCU SI STR. T. ARGHEZI", 5m, 25 },
                    { 133, 198, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6705), "BUCUR OBOR", "PE STR. HALELE OBOR", 2.5m, 198 },
                    { 132, 49, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6664), "BOTEANU", "INTRE STR. C.A. ROSETTI SI STR. D.I. DOBRESCU", 5m, 49 },
                    { 131, 82, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6623), "BISERICA ENEI", "INTRE STR. ACADEMIEI SI STR. EDGAR QUINET", 10m, 82 },
                    { 103, 59, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4922), "ALEEA PRIVIGHETORILOR 1", "INTRE AL.PRIVIGHETORILOR SI SERBAN CANTACUZINO", 2.5m, 59 },
                    { 104, 56, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4996), "ALEXANDRU BELDIMAN", "INTRE BD. REGINA ELISABETA SI STR. EFORIE", 5m, 56 },
                    { 105, 153, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5052), "ALEXANDRU CONSTANTINESCU", "INTRE BD. MARASESTI SI BD. ION MIHALACHE", 2.5m, 153 },
                    { 106, 57, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5097), "ALEXANDRU IOAN CUZA 1", "INTRE GH. DUCA SI DR. I. FELIX", 5m, 57 },
                    { 107, 47, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5162), "ALEXANDRU IOAN CUZA 2", "INTRE GH. DUCA SI C-TIN DISESCU", 5m, 47 },
                    { 108, 76, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5223), "ALEXANDRU IOAN CUZA 3", "INTRE SOS. N.TITULESCU SI STR. C-TIN DISESCU", 5m, 76 },
                    { 109, 7, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5286), "ARISTIDE DEMETRIADE", "INTRE STR. BREZOIANU SI STR. GEORGE VRACA", 5m, 7 },
                    { 110, 41, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5338), "PICTOR ARTHUR VERONA", "STR. PICTOR VERONA, INTRE BD. MAGHERU SI STR. PITAR MOS", 5m, 41 },
                    { 111, 70, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5378), "ARTHUR VERONA 2", "INTRE PITAR MOS SI J.L.CALDERON", 5m, 70 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 112, 223, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5538), "AVIATORILOR 1D", "INTRE ROND PESCARUS SI PIATA CHARLES DE GAULLE", 5m, 223 },
                    { 113, 181, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5592), "AVIATORILOR 1S", "INTRE ROND PESCARUS SI PIATA CHARLES DE GAULLE", 5m, 181 },
                    { 114, 175, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5634), "AVIATORILOR 2D", "INTRE PIATA CHARLES DE GAULLE SI GH. DEMETRIADE", 5m, 175 },
                    { 115, 181, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5677), "AVIATORILOR 2S", "INTRE PTA CHARLES DE GAULLE SI STR. GH. DEMETRIADE", 5m, 181 },
                    { 162, 21, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8042), "CHRISTIAN TELL", "INTRE STR. BISERICA AMZEI SI PIATA AMZEI", 5m, 21 },
                    { 116, 85, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5720), "AVIATORILOR 3S", "INTRE PIATA VICTORIEI SI STR. CAPITAN GHE. DEMETRIADE", 5m, 85 },
                    { 118, 159, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5808), "AVRIG 2", "INTRE SOS. IANCULUI SI STR. RITMULUI", 2.5m, 159 },
                    { 119, 23, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5870), "BALANESCU ROSETTI", "INTRE CALEA FLOREASCA SI STR. BANUL ANTONACHE", 2.5m, 23 },
                    { 120, 65, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5912), "BANU MANTA 1", "INTRE STR. G-RAL VLADOIANU BARBU SI STR. FROSA SARANDY", 2.5m, 65 },
                    { 121, 65, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5956), "BANU MANTA 2", "INTRE STR. FROSA SARANDY SI BD. I. MIHALACHE", 2.5m, 65 },
                    { 122, 126, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5996), "BANUL ANTONACHE", "", 2.5m, 126 },
                    { 123, 68, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6048), "BARBU DELAVRANCEA", "INTRE BD. ION MIHALACHE SI STR. ION MINCU", 5m, 68 },
                    { 124, 495, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6091), "BASARABIA 1", "INTRE PIATA MUNCII SI BD. CHISINAU", 2.5m, 495 },
                    { 125, 58, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6136), "BATISTEI", "INTRE BD. NICOLAE BALCESCU SI STR. I.L.CARAGIALE", 10m, 58 },
                    { 126, 22, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6183), "BCU – BIBLIOTECA CENTRALA UNIVERSITARA", "STR. DEM. I. DOBRESCU, INTRE CALEA VICTORIEI SI STR. BOTEANU", 5m, 22 },
                    { 127, 36, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6384), "GENERAL BERTHELOT", "INTRE STR. L.CAZAVILLIAN SI STR. POPA TATU", 5m, 36 },
                    { 128, 57, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6477), "GENERAL BERTHELOT 2", "INTRE STR. LUTERANA SI CALEA VICTORIEI", 5m, 57 },
                    { 129, 89, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6543), "GENERAL BERTHELOT 3", "INTRE STR. POPA TATU SI STR. BERZEI", 5m, 89 },
                    { 130, 59, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(6584), "BIBESCU VODA", "INTRE SP. INDEPENDENTEI SI BD. D. CANTEMIR", 5m, 59 },
                    { 117, 145, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(5766), "AVRIG 1", "INTRE BD. FERDINAND SI STR. CHIRISTIGIILOR", 2.5m, 145 },
                    { 226, 12, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(838), "IANCU DE HUNEDOARA 2", "INTRE INTR. GENEVA SI STR. CLOPOTARII VECHI", 5m, 12 },
                    { 164, 72, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8126), "CINA 2", "INTRE STR. B. FRANKLIN SI STR. EPISCOPIEI", 5m, 72 },
                    { 165, 35, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8169), "CLOPOTARII VECHI", "INTRE STR. GRIGORE ALEXANDRESCU SI BD. IANCU DE HUNEDOARA", 5m, 35 },
                    { 198, 152, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9594), "FRUMOASA", "INTRE CALEA VICTORIEI SI STR. SEVASTOPOL", 5m, 152 },
                    { 199, 119, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9634), "GARA BANEASA", "ESPLANADA GARII BANEASA SI STR. TIPOGRAFILOR", 5m, 119 },
                    { 200, 13, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9695), "GARA CEAS", "PIATA GARII DE NORD", 5m, 13 },
                    { 201, 39, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9781), "GARA PARC", "PIATA GARII DE NORD", 5m, 39 },
                    { 202, 25, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9827), "GARII DE NORD 1", "STR. GARII DE NORD, INTRE STR. BERZEI SI STR. CAMELIEI", 2.5m, 25 },
                    { 203, 77, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9867), "GARII DE NORD 2", "STR. GARII DE NORD, INTRE STR. CAMELIEI SI PTA. GARII DE NORD", 2.5m, 77 },
                    { 204, 147, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9908), "GEORGE CALINESCU", "", 2.5m, 147 },
                    { 205, 35, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9949), "GEORGE ENESCU", "STR. GEORGE ENESCU, INTRE STR. MENDELEEV SI BD. MAGHERU", 5m, 35 },
                    { 206, 65, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9990), "GEORGE ENESCU 3", "INTRE STR. D.I.MENDELEEV SI CALEA VICTORIEI", 5m, 65 },
                    { 207, 54, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(30), "GHEORGHE DUCA", "INTRE CALEA GRIVITEI SI A.I.CUZA", 2.5m, 54 },
                    { 208, 46, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(74), "GHEORGHE LAZAR", "INTRE SF. CONSTANTIN SI GH.COBALCESCU", 2.5m, 46 },
                    { 209, 31, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(115), "GRADINA CU CAI", "INTRE SP. INDEPENDENTEI SI PTA. M.KOGALNICEANU", 5m, 31 },
                    { 210, 30, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(154), "GRADINITA – ROSETTI", "STR. C.A.ROSETTI, INTRE STR. T. ARGHEZI SI STR. DAVID PRAPORGESCU", 10m, 30 },
                    { 197, 93, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9554), "FICUSULUI 2", "INTRE STR. H.MACELARIU SI BD. AEROGARII", 2.5m, 93 },
                    { 211, 41, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(193), "GRIGORE ALEXANDRESCU", "STR. GRIGORE ALEXANDRESCU, INTRE CALEA VICTORIEI SI BD. LASCAR CATARGIU", 5m, 41 },
                    { 213, 118, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(273), "GRIGORE COBALCESCU", "INTRE BD. SCHITU MAGUREANU SI STR. BERZEI", 5m, 118 },
                    { 214, 82, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(312), "GUTENBERG", "", 2.5m, 82 },
                    { 215, 15, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(353), "HALELOR", "STR. HALELOR, INTRE STR. SELARI SI STR. CALDARARI", 10m, 15 },
                    { 216, 99, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(394), "HERASTRAU 1 (PAVILION H)", "PARC HERASTRAU", 5m, 99 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 217, 132, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(474), "HERASTRAU 2 BOA", "PARC MIORITA (HERASTRAU)", 5m, 132 },
                    { 218, 14, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(520), "HOROSCOP 1", "BD. D. CANTEMIR - INTRE SPLAIUL UNIRII SI STR. BIBESCU VODA", 5m, 14 },
                    { 219, 11, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(560), "HOROSCOP 2 SITRACO", "BD. D. CANTEMIR - INTRE SPLAIUL UNIRII SI STR. BIBESCU VODA", 5m, 11 },
                    { 220, 24, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(604), "HOROSCOP 3 SPLAI", "BD. D. CANTEMIR - SPLAIUL UNIRII", 5m, 24 },
                    { 221, 20, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(643), "HRISTO BOTEV 1", "INTRE STR. SCAUNE SI STR. IVO ANDRIC", 5m, 20 },
                    { 222, 25, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(682), "HRISTO BOTEV 2", "INTRE STR. NEGUSTORI SI STR. TEODOR STEFANESCU", 5m, 25 },
                    { 223, 91, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(719), "IACOB FELIX 1", "INTRE STR. GHE. POLIZU SI SOS. N. TITULESCU", 2.5m, 91 },
                    { 224, 33, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(760), "IACOB FELIX 2", "INTRE SOS. N. TITULESCU SI BD. I. MIHALACHE", 2.5m, 33 },
                    { 225, 36, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(799), "IANCU DE HUNEDOARA 1", "INTRE BD. LASCAR CATARGIU SI INTR. GENEVA", 5m, 36 },
                    { 212, 216, "București", new DateTime(2021, 7, 14, 1, 38, 30, 887, DateTimeKind.Local).AddTicks(234), "GRIGORE ALEXANDRESCU 2", "INTRE BD. LASCAR CATARGIU SI CALEA DOROBANTI", 5m, 216 },
                    { 102, 8, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4851), "ALEEA CAUZASI", "INTERSECTIA CU BD. MIRCEA VODA", 5m, 8 },
                    { 196, 46, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9516), "FICUSULUI 1", "INTRE STR. E.VACARESCU SI STR. H.MACELARIU", 2.5m, 46 },
                    { 194, 73, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9435), "EVA", "BD. GHE. MAGHERU, INTRE STR. G.ENESCU SI STR. ANASTASIE SIMU", 5m, 73 },
                    { 166, 54, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8211), "CONSERVATOR – UNESCO", "STR. STIRBEI VODA", 5m, 54 },
                    { 167, 84, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8250), "CONSTANTIN MILLE", "INTRE CALEA VICTORIEI SI STR. I. BREZOIANU", 5m, 84 },
                    { 168, 33, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8291), "CONSTANTIN NACU", "INTRE PTA. ITALIANA SI BD. CAROL I", 5m, 33 },
                    { 169, 92, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8372), "CRANGASI", "PTA. CRANGASI", 2.5m, 92 },
                    { 170, 36, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8419), "CRETULESCU", "ALEEA DE LANGA BISERICA CRETULESCU", 5m, 36 },
                    { 171, 40, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8458), "DACIA 2", "BD. DACIA", 5m, 40 },
                    { 172, 21, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8501), "DACIA MONTEORU", "BD. DACIA X CALEA VICTORIEI", 5m, 21 },
                    { 173, 69, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8541), "DANIELOPOL", "INTRE SPLAIUL INDEPENDENTEI SI STR. POENARU BORDEA", 5m, 69 },
                    { 174, 64, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8581), "DECEBAL 1", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 64 },
                    { 175, 44, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8620), "DECEBAL 2", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 44 },
                    { 176, 53, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8661), "DECEBAL 3", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 53 },
                    { 177, 67, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8703), "DIANEI", "INTRE ITALIANA SI CAROL I", 5m, 67 },
                    { 178, 72, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8744), "DINICU GOLESCU (GARA)", "", 2.5m, 72 },
                    { 195, 188, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9473), "EXPOZITIEI", "BD. EXPOZITIEI (ZONA ROMEXPO)", 5m, 188 },
                    { 179, 111, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8783), "DINICU GOLESCU 1", "INTRE STR. M. VULCANESCU SI PTA. GARII DE NORD", 2.5m, 111 },
                    { 181, 18, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8865), "DOAMNEI 1", "STR. DOAMNEI, INTRE BD. I.C.BRATIANU SI INTR. SELARI", 10m, 18 },
                    { 182, 21, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8905), "DOAMNEI 2", "", 10m, 21 },
                    { 183, 28, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8945), "DOAMNEI 4", "", 10m, 28 },
                    { 184, 57, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8986), "DOMNITA ANASTASIA", "INTRE STR. LIPSCANI SI STR. A. SALIGNY", 5m, 57 },
                    { 185, 21, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9069), "DOROBANTI", "PTA. DOROBANTI", 5m, 21 },
                    { 186, 11, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9115), "DOROBANTI – LAHOVARI", "", 5m, 11 },
                    { 187, 11, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9155), "DOROBANTI DACIA", "INTERSECTIE BD. DACIA SI CALEA DOROBANTILOR", 5m, 11 },
                    { 188, 19, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9197), "DRISTOR 1", "INTRE C.RESSU SI STATIE METROU", 2.5m, 19 },
                    { 189, 21, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9236), "DRISTOR 2", "INTRE STATIE METROU SI GRAULUI", 2.5m, 21 },
                    { 190, 107, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9275), "EDGAR QUINET", "INTRE CALEA VICTORIEI SI BISERICA ENEI", 10m, 107 },
                    { 191, 48, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9314), "EFORIE", "INTRE C.VICTORIEI SI STR. D. ANASTASIA", 5m, 48 },
                    { 192, 64, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9355), "ELENA VACARESCU", "INTRE BD. FICUSULUI SI SOS. BUCURESTI-PLOIESTI", 2.5m, 64 },
                    { 193, 77, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(9395), "EPISCOPIEI", "INTRE N.GOLESCU SI C. VICTORIEI", 5m, 77 },
                    { 180, 120, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(8824), "DIONISIE LUPU", "INTRE STR. G-RAL EREMIA GRIGORESCU SI C.A.ROSETTI", 5m, 120 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[] { 101, 29, "București", new DateTime(2021, 7, 14, 1, 38, 30, 886, DateTimeKind.Local).AddTicks(4638), "Alee Legatura Banu Antonache si Calea Floreasca", "", 2.5m, 29 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 1, new DateTime(2021, 7, 14, 1, 38, 30, 463, DateTimeKind.Local).AddTicks(1002), "administrator220@easypark.com", "ADMINISTRATOR", "$2a$11$mORWUuU8fov17MqHkRdoHupEq1O8Vc8B/eiKcR7Db61GFNBGro9uy", "0723678956", 220 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 3, new DateTime(2021, 7, 14, 1, 38, 30, 639, DateTimeKind.Local).AddTicks(1852), "admin_area342@easypark.com", "ADMIN_AREA342", "$2a$11$72iv7TSNVDWqLSFTFwodqe5l/3LzJuH3aj7cGBfO4JzsfT8U92fyG", "0734670055", 210 });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "CreatedOn", "ParkingAreaId", "UserId" },
                values: new object[] { 1, new DateTime(2021, 7, 14, 1, 38, 30, 808, DateTimeKind.Local).AddTicks(8088), 342, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingAreas",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
