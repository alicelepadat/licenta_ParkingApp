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
                    { 100, 96, "București", new DateTime(2021, 7, 12, 11, 12, 41, 443, DateTimeKind.Local).AddTicks(6964), "Academiei", "Între bd. Regina Elisabeta și I. Campineanu", 10m, 96 },
                    { 261, 156, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8054), "NICOLAE CARAMFIL", "BD. NICOLAE CARANFIL", 10m, 156 },
                    { 262, 98, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8086), "NICOLAE FILIPESCU", "INTRE STR. C.A. ROSETTI SI STR. BATISTEI", 10m, 98 },
                    { 263, 32, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8198), "NICOLAE GOLESCU", "INTRE STR. G. ENESCU SI STR. EPISCOPIEI", 5m, 32 },
                    { 264, 35, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8241), "NICOLAE IORGA", "INTRE CALEA VICTORIEI SI STR. HENRI COANDA", 5m, 35 },
                    { 265, 35, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8274), "NICOLAE TITULESCU", "INTRE INTR. COJESTI SI STR. DR. IACOB FELIX", 2.5m, 35 },
                    { 266, 163, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8306), "OCTAVIAN GOGA 1", "INTRE CALEA DUDESTI SI STR. NERVA TRAIAN", 2.5m, 163 },
                    { 267, 18, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8339), "OCTAVIAN GOGA 3", "ARTERA DREAPTA PASAJ MARASESTI", 5m, 18 },
                    { 268, 138, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8372), "OCTAVIAN GOGA 4", "DEASUPRA PASAJ MARASESTI", 5m, 138 },
                    { 269, 50, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8405), "OCTAVIAN GOGA 5", "DEASUPRA PASAJ MARASESTI - DREAPTA PARCAJ GOGA 4", 5m, 50 },
                    { 270, 80, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8437), "OPERA", "PTA. VICTOR BABES", 5m, 80 },
                    { 271, 12, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8468), "ORIZONT", "INTR. JEAN GEORGESCU, LA INTERSECTIA CU STR. DEM I. DOBRESCU", 10m, 12 },
                    { 272, 28, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8501), "OTETELESANU", "INTRE STR. MATEI MILLO SI STR. C-TIN MILLE", 5m, 28 },
                    { 273, 11, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8532), "PANIPAT", "BD. BRATIANU", 10m, 11 },
                    { 274, 266, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8566), "PANTELIMON 1S", "SOS. MORARILOR - SOS. VERGULUI", 2m, 266 },
                    { 275, 61, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8598), "PECO ANGHEL SALIGNY", "STR. ANGHEL SALIGNY", 5m, 61 },
                    { 276, 72, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8632), "PECO BARIERE", "SP. INDEPENDENTEI, INTRE STR. A. SALIGNY SI ELIE RADU", 5m, 72 },
                    { 277, 25, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8664), "PECO M.I.", "INTERSECTIE A. SALIGNY - LIPSCANI", 5m, 25 },
                    { 278, 13, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8696), "PECO POMPIERI", "INTRE STR. A. SALIGNY SI ELIE RADU", 5m, 13 },
                    { 279, 99, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8763), "PESCARUS", "ALEEA DE ACCES IN PARCUL HERASTRAU - LA RESTAURANTUL PESCARUS", 5m, 99 },
                    { 280, 80, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8801), "PIATA ALBA IULIA 1", "INTRE BD. UNIRII SI BD. DECEBAL (ALVEOLE)", 2.5m, 80 },
                    { 281, 77, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8834), "PIATA AMZEI 1", "INTRE CALEA VICTORIEI SI STR. MENDELEEV", 5m, 77 },
                    { 282, 65, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8867), "PIATA AMZEI 2", "INTRE STR. BISERICA AMZEI SI PIATA AMZEI", 5m, 65 },
                    { 283, 47, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8898), "PIATA AMZEI 3", "INTRE STR. CHRISTIAN TELL SI PIATA AMZEI", 5m, 47 },
                    { 284, 37, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8931), "PIATA CHARLES DE GAULLE", "ALVEOLE PARTEA DREAPTA P-TA CH. DE GAULLE (BD. PREZAN)", 5m, 37 },
                    { 285, 494, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8962), "PIATA CONSTITUTIEI", "PIATA CONSTITUTIEI - PASTILA (FARA ALVEOLE)", 5m, 494 },
                    { 286, 25, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8995), "PIATA GEMENI", "PIATA GEMENI", 5m, 25 },
                    { 287, 19, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9025), "PIATA ITALIANA", "ITALIANA X STR. V. LASCAR X STR. C-TIN NACU", 5m, 19 },
                    { 260, 24, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(8023), "NICOLAE BALCESCU 2", "INTRE STR. C.A. ROSETTI SI STR. DEM. I. DOBRESCU", 10m, 24 },
                    { 259, 44, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7990), "NICOLAE BALCESCU 1", "INTRE STR. DEM. I. DOBRESCU SI STR. I. CAMPINEANU", 10m, 44 },
                    { 258, 35, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7960), "NERVA TRAIAN", "", 5m, 35 },
                    { 257, 29, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7929), "NATIUNILE UNITE", "INTRE PTA. NATIUNILE UNITE SI STR. SF. APOSTOLI", 10m, 29 },
                    { 229, 52, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6927), "ION BREZOIANU 3", "INTRE WALTER MARACINEANU SI POIANA NARCISELOR", 5m, 52 },
                    { 230, 73, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6958), "ION CAMPINEANU", "INTRE CALEA VICTORIEI SI BD. N. BALCESCU", 10m, 73 },
                    { 231, 45, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7034), "ION CAMPINEANU (SUPERB)", "INTRE STR. STIRBEI VODA SI STR. W. MARACINEANU", 5m, 45 },
                    { 232, 57, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7070), "ION CAMPINEANU 1", "INTRE W.MARACINEANU SI CALEA VICTORIEI", 5m, 57 },
                    { 233, 24, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7120), "ION GHICA", "INTRE I.C.BRATIANU SI DOAMNEI", 10m, 24 },
                    { 234, 46, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7155), "JEAN LOUIS CALDERON 1", "INTRE ITALIANA SI C.A.ROSETTI", 10m, 46 },
                    { 235, 18, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7186), "JEAN LOUIS CALDERON 2", "INTRE C.A.ROSETTI SI ITALIANA", 10m, 18 },
                    { 236, 49, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7219), "JEAN LOUIS CALDERON 3", "INTRE ICOANEI SI PTA CANTACUZINO", 10m, 49 },
                    { 237, 84, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7250), "KISELEFF ALVEOLA", "INTRE MONETARIEI SI ION MINCU", 5m, 84 },
                    { 238, 15, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7283), "LASCAR CATARGIU – HOTEL MINERVA", "INTRE STR. H. COANDA SI STR. G-RAL GHE. MANU", 5m, 15 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 239, 44, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7312), "LIBERTATII", "INTRE BD. NATIUNILE UNITE SI SPLAIUL INDEPENDENTEI, PE PARTE ADIACENTA PARCULUI", 5m, 44 },
                    { 240, 11, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7345), "LIDO", "INTRE STR. ANASTASIE SINU SI STR. B. FRANKLIN", 5m, 11 },
                    { 241, 60, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7376), "LIDO TERASA", "INTRE CALEA VICTORIEI SI BD. MAGHERU", 5m, 60 },
                    { 288, 90, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9057), "PIATA LIBERTATII 1", "INTRE STR. C-TIN ISTRATI SI BD. MARASESTI (PARCUL CAROL)", 5m, 90 },
                    { 242, 27, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7409), "LIPSCANI 1", "INTRE STR. A.SALIGNY SI STR. I.BREZOIANU", 5m, 27 },
                    { 244, 53, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7472), "LUTERANA", "INTRE STR. STIRBEI VODA SI STR. G-RAL BERTHELOT", 5m, 53 },
                    { 245, 29, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7503), "MAGAZIN VICTORIA", "MAGAZIN VICTORIA", 5m, 29 },
                    { 246, 62, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7535), "MARIA ROSETTI", "INTRE STR ION LUCA CARAGIALE SI STR. SF SPIRIDON", 5m, 62 },
                    { 247, 43, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7602), "MARRIOTT", "ZONA PTA. ARSENALULUI", 5m, 43 },
                    { 248, 31, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7639), "MATEI BASARAB 1", "INTRE STR. MIRCEA VODA SI BD. CORNELIU COPOSU", 10m, 31 },
                    { 249, 55, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7671), "MATEI MILLO", "INTRE CALEA VICTORIEI SI STR. G. VRACA", 5m, 55 },
                    { 250, 113, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7706), "MENDELEEV", "STR. MENDELEEV, INTRE STR. G. ENESCU SI PTA. ROMANA", 5m, 113 },
                    { 251, 20, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7736), "MINISTERUL MEDIULUI", "BD. LIBERTATII", 5m, 20 },
                    { 252, 319, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7767), "MIRCEA VODA", "BD C. COPOSU - NERVA TRAIAN", 5m, 319 },
                    { 253, 20, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7798), "BD. MIRCEA VODA, HOTEL MERCURE", "", 5m, 20 },
                    { 254, 29, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7830), "BD. MIRCEA VODA, TIMPURI NOI", "INTERSECTIE BD. MIRCEA VODA SI STR. NERVA TRAIAN - PARC TIMPURI NOI", 5m, 29 },
                    { 255, 80, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7861), "MIRCEA VULCANESCU", "INTRE STR. D.GOLESCU SI CALEA PLEVNEI", 5m, 80 },
                    { 256, 88, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7894), "MIRCEA VULCANESCU 1", "INTRE CALEA GRIVITEI SI STR. HORATIU", 5m, 88 },
                    { 243, 30, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(7439), "LIPSCANI 2", "INTRE BD. I.C. BRATIANU SI CALEA MOSILOR", 5m, 30 },
                    { 289, 18, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9090), "PIATA LIBERTATII 2", "INTRE BD. MARASESTI SI STR. 11 IUNIE", 5m, 18 },
                    { 290, 136, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9121), "PIATA REVOLUTIEI", "INTRE STR. ION CAMPINEANU SI STR. DEM I. DOBRESCU", 5m, 136 },
                    { 291, 93, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9152), "PIATA VICTORIEI", "PTA. VICTORIEI (DEASUPRA PASAJULUI RUTIER)", 5m, 93 },
                    { 324, 384, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(312), "SOS. NORDULUI", "INTRE BD. BEIJING SI STR. GRIGORE GAFENCU", 5m, 384 },
                    { 325, 39, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(345), "SOS. NORDULUI – AMBASADA CHINEI", "INTRE BD. BEIJING SI ALEEA PRIPORULUI", 5m, 39 },
                    { 326, 39, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(377), "SPERANTEI", "INTRE STR. AR. CALINESCU SI CAROL I", 5m, 39 },
                    { 327, 24, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(408), "SPLAI EXIM BANK ALVEOLA", "SP. INDEPENDENTEI", 5m, 24 },
                    { 328, 44, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(478), "SPLAI TURN", "PE SP. INDEPENDENTEI, LA INTERSECTIA CU BD. NATIUNILE UNITE", 5m, 44 },
                    { 329, 14, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(514), "SPLAIUL INDEPENDENTEI 3", "INTRE STR. GRADINA CU CAI SI STR. B.P.HASDEU", 5m, 14 },
                    { 330, 23, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(547), "SPLAIUL INDEPENDENTEI 4", "INTRE BD. SCHITU MAGUREANU SI GRADINA CU CAI", 5m, 23 },
                    { 331, 23, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(578), "SPLAIUL INDEPENDENTEI 5", "INTRE STR. ILFOV SI STR. MIHAI VODA", 5m, 23 },
                    { 332, 20, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(611), "SPLAIUL INDEPENDENTEI 6", "INTRE CALEA VICTORIEI SI STR. ILFOV", 5m, 20 },
                    { 333, 167, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(644), "SPLAIUL UNIRII", "INTRE STR. D. CANTEMIR SI BD. MARASESTI", 5m, 167 },
                    { 334, 322, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(676), "STEFAN CEL MARE 1", "INTRE BUCUR OBOR SI VASILE LASCAR", 2.5m, 322 },
                    { 335, 260, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(709), "STEFAN CEL MARE 2", "INTRE VASILE LASCAR SI CALEA FLOREASCA", 2.5m, 260 },
                    { 336, 38, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(743), "TAKE IONESCU", "INTRE BD. GHE. MAGHERU SI STR. MENDELEEV", 5m, 38 },
                    { 323, 42, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(279), "SLANIC", "", 10m, 42 },
                    { 337, 14, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(776), "TERASA SIDNEY", "INTRE CALEA VICTORIEI SI LASCAR CATARGIU", 5m, 14 },
                    { 339, 36, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(841), "THOMAS MASARYK", "INTRE STR. VASILE LASCAR SI STR. J.L. CALDERON", 5m, 36 },
                    { 340, 41, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(876), "TONITZA", "ZONA DELIMITATA DE STR. NICOLAE TONITZA, STR. FILITTI SI SP. INDEPENDENTEI", 10m, 41 },
                    { 341, 14, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(909), "TRAIAN", "INTRE STR. PLANTELOR SI STR. ST. MIHAILEANU", 5m, 14 },
                    { 342, 32, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(943), "TRAIAN VUIA", "INTRE BD. N. BALCESCU SI STR. VASILE CONTA", 10m, 32 },
                    { 343, 125, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(975), "TUDOR ARGHEZI", "", 10m, 125 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 344, 20, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1066), "UDRISTE – STRADA", "PE STR. MATEI BASARAB, INTRE BD. CORNELIU COPOSU SI BD. MIRCEA VODA", 5m, 20 },
                    { 345, 30, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1106), "UNIREA PANTA", "BD. CORNELIU COPOSU, INTRE BD. I.C.BRATIANU SI STR. SF. VINERI", 10m, 30 },
                    { 346, 14, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1139), "UNIREA PASAJ", "BD. I.C.BRATIANU", 10m, 14 },
                    { 347, 211, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1173), "UNIRII", "BD. UNIRII (PTA. CONSTITUTIEI - PTA. UNIRII)", 5m, 211 },
                    { 348, 171, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1208), "BD. UNIRII – ALVEOLA 1D", "INTRE PIATA UNIRII SI MIRCEA VODA", 10m, 171 },
                    { 349, 247, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1241), "BD. UNIRII – ALVEOLA 1S", "INTRE PTA UNIRII SI MIRCEA VODA", 10m, 247 },
                    { 350, 34, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1275), "BD. UNIRII – ALVEOLA 2D", "INTRE MIRCEA VODA SI NERVA TRAIAN", 5m, 34 },
                    { 351, 124, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1310), "BD. UNIRII – ALVEOLA 2S", "INTRE MIRCEA VODA SI BD. UNIRII TRONSON S3", 5m, 124 },
                    { 338, 56, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(809), "TERASA SIDNEY 2", "INTRE CALEA VICTORIEI SI STR. BUZESTI", 5m, 56 },
                    { 228, 19, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6893), "ION BREZOIANU 2", "INTRE LIPSCANI SI DOMNITA ANASTASIA", 5m, 19 },
                    { 322, 29, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(248), "SILFIDELOR", "", 5m, 29 },
                    { 320, 82, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(182), "SFINTII APOSTOLI", "", 5m, 82 },
                    { 292, 10, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9184), "PIATA VICTORIEI SPRING TIME", "PTA. VICTORIEI", 5m, 10 },
                    { 293, 127, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9215), "PIATA WALTER MARACINEANU", "", 5m, 127 },
                    { 294, 52, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9248), "PITAR MOS", "INTRE C.A.ROSETTI SI J.MICHELET", 5m, 52 },
                    { 295, 27, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9314), "POIANA NARCISELOR 1", "INTRE STR. I.CAMPINEANU SI STR. I.BREZOIANU", 5m, 27 },
                    { 296, 40, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9352), "POIANA NARCISELOR 2", "INTRE STR. STIRBEI VODA SI STR. VASILE SION", 5m, 40 },
                    { 297, 23, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9384), "POLIZU", "INTRE STR. DR. VARNALI SI STR. IACOB FELIX", 5m, 23 },
                    { 298, 79, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9416), "POLONA 1", "INTRE ION BOGDAN SI BROSTEANU", 5m, 79 },
                    { 299, 49, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9446), "POLONA 2", "INTRE ION BOGDAN SI STEFAN CEL MARE", 5m, 49 },
                    { 300, 41, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9479), "POMPILIU ELIADE", "INTRE PTA. M. KOGALNICEANU SI STR. SF. CONSTANTIN", 5m, 41 },
                    { 301, 160, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9510), "POPA TATU", "INTRE STR. STIRBEI VODA SI STR. BERZEI", 5m, 160 },
                    { 302, 15, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9543), "POSTA VITAN 1", "INTRE STR. O.GOGA SI CALEA VITAN", 2.5m, 15 },
                    { 303, 208, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9576), "PIATA ALBA IULIA", "ROND PTA. ALBA IULIA", 2.5m, 208 },
                    { 304, 23, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9609), "PIATA LAHOVARI", "PIATA LAHOVARI", 5m, 23 },
                    { 321, 13, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(215), "SFINTII VOIEVOZI", "LA INTERSECTIA STR. SF. VOIEVOZI SI MIHAIL MOXA", 5m, 13 },
                    { 305, 527, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9641), "PIATA PRESEI LIBERE", "ALEILE INCONJURATOARE CASA PRESEI", 2.5m, 527 },
                    { 307, 24, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9705), "RAUREANU", "INTRE CALEA VICTORIEI SI SPLAIUL INDEPENDENTEI", 5m, 24 },
                    { 308, 16, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9739), "REGINA ELISABETA", "BD. REGINA ELISABETA", 5m, 16 },
                    { 309, 25, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9772), "RIGAS", "INTRE STR. BREZOIANU SI PARC CISMIGIU", 5m, 25 },
                    { 310, 25, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9804), "ROND PESCARUS", "ALVEOLA PARC HERASTRAU (BD. AVIATORILOR - BD. BEIJING)", 5m, 25 },
                    { 311, 26, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9836), "ROSETTI SEMAFOR", "INTRE PRAPORGESCU SI J.L.CALDERON", 10m, 26 },
                    { 312, 166, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9917), "SALA PALATULUI", "ALEILE DIN JURUL SALII PALATULUI", 5m, 166 },
                    { 313, 140, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9951), "SCHITU MAGUREANU", "BD. SCHITU MAGUREANU", 5m, 140 },
                    { 314, 24, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9984), "SCHITU MAGUREANU 2", "BD. SCHITU MAGUREANU", 5m, 24 },
                    { 315, 4, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(17), "SCOALEI", "", 10m, 4 },
                    { 316, 110, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(50), "SEVASTOPOL", "", 5m, 110 },
                    { 317, 117, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(83), "SFANTA VINERI (STRADAL)", "INTRE BD. MIRCEA VODA SI STR. MAMULARI", 5m, 117 },
                    { 318, 160, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(115), "SFANTA VINERI 2", "ADICENT BD. MIRCEA VODA", 5m, 160 },
                    { 319, 45, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(148), "SFANTUL CONSTANTIN", "INTRE STR. POMPILIU ELIADE SI CALEA PLEVNEI", 5m, 45 },
                    { 306, 108, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(9674), "RADU BELLER", "STR. AV. RADU BELLER", 2.5m, 108 },
                    { 227, 47, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6858), "ION BREZOIANU", "INTRE BD. REGINA ELISABETA SI INTR. RIGAS", 5m, 47 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 226, 12, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6828), "IANCU DE HUNEDOARA 2", "INTRE INTR. GENEVA SI STR. CLOPOTARII VECHI", 5m, 12 },
                    { 225, 36, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6796), "IANCU DE HUNEDOARA 1", "INTRE BD. LASCAR CATARGIU SI INTR. GENEVA", 5m, 36 },
                    { 133, 198, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3538), "BUCUR OBOR", "PE STR. HALELE OBOR", 2.5m, 198 },
                    { 134, 25, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3572), "C.A. ROSETTI", "INTRE BD. N. BALCESCU SI STR. T. ARGHEZI", 5m, 25 },
                    { 135, 94, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3603), "CADEREA BASTILIEI 1", "INTRE BD. LASCAR CATARGIU SI STR. I. SLATINEANU", 5m, 94 },
                    { 136, 57, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3634), "CADEREA BASTILIEI 2", "INTRE BD. I. SLATINEANU SI BD. IANCU DE HUNEDOARA", 5m, 57 },
                    { 137, 125, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3666), "CALEA FLOREASCA 1", "INTRE SOS. STEFAN CEL MARE SI STR. TUDOR VIANU", 2.5m, 125 },
                    { 138, 44, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3698), "CALEA FLOREASCA 2", "INTRE STR. TUDOR VIANU SI STR. BALANESCU ROSETTI", 2.5m, 44 },
                    { 139, 63, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3728), "CALEA FLOREASCA 3", "INTRE STR. BALANESCU ROSETTI SI STR. MIHAIL GLINKA", 2.5m, 63 },
                    { 140, 36, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3797), "CALEA FLOREASCA 4", "INTRE STR. MIHAIL GLINKA SI STR. CEAIKOVSKI", 2.5m, 36 },
                    { 141, 53, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3831), "CALEA FLOREASCA 5", "INTRE STR. CEAIKOVSKI SI STR. ANCUTA BANEASA", 2.5m, 53 },
                    { 142, 34, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3863), "CALEA GRIVITEI 1", "INTRE PASAJ BASARAB SI VASILE STR. TARUSANU", 2.5m, 34 },
                    { 143, 71, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3893), "CALEA GRIVITEI 2", "INTRE STR. POLIZU SI STR. SF. VOIEVOZI", 5m, 71 },
                    { 144, 40, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3926), "CALEA GRIVITEI 3", "INTRE STR. SF. VOIEVOZI SI BD. DACIA", 5m, 40 },
                    { 145, 61, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3958), "CALEA GRIVITEI 4", "INTRE BD. DACIA SI CALEA VICTORIEI", 5m, 61 },
                    { 132, 49, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3505), "BOTEANU", "INTRE STR. C.A. ROSETTI SI STR. D.I. DOBRESCU", 5m, 49 },
                    { 146, 15, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3989), "CALEA MOSILOR", "INTRE STR. BARATIEI SI STR. SF. VINERI", 10m, 15 },
                    { 148, 85, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4052), "CALEA PLEVNEI 1", "INTRE PTA. M.KOGALNICEANU SI STR. SF.CONSTANTIN", 5m, 85 },
                    { 149, 76, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4082), "CALEA PLEVNEI 2", "INTRE STR. BERZEI SI STR. STIRBEI VODA", 2.5m, 76 },
                    { 150, 27, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4114), "CALEA PLEVNEI 3", "INTRE STR. MIRCEA VULCANESCU SI STR. WITING", 2.5m, 27 },
                    { 151, 52, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4144), "CALEA PLEVNEI 4", "INTRE STR. WITING SI STR. PISONI", 2.5m, 52 },
                    { 152, 48, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4175), "CALEA PLEVNEI 5", "INTRE STR. PISONI SI STR. BARIEREI", 2.5m, 48 },
                    { 153, 12, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4205), "CALEA PLEVNEI 6", "INTRE STR. BARIEREI SI STR. AFLUENTULUI", 2.5m, 12 },
                    { 154, 107, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4235), "CALEA RAHOVEI", "INTRE BD. LIBERTATII SI STR. SABINELOR", 2.5m, 107 },
                    { 155, 14, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4264), "CALEA VICTORIEI 1", "INTRE PTA. VICTORIEI SI STR. SEVASTOPOL", 5m, 14 },
                    { 156, 31, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4333), "CALEA VICTORIEI 2", "INTRE CALEA GRIVITEI SI STR. BANULUI", 5m, 31 },
                    { 157, 475, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4368), "CANDIANO POPESCU", "INTRE PTA. LIBERTATII SI CALEA SERBAN VODA", 2.5m, 475 },
                    { 158, 20, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4400), "CEC BANCOREX", "STR. MIHAI VODA, INTRE CALEA VICTORIEI SI STR. ILFOV", 5m, 20 },
                    { 159, 60, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4432), "CEC JUDECATORIE", "STR. ILFOV, INTRE SPLAI INDEP. SI STR. MIHAI VODA", 5m, 60 },
                    { 160, 30, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4465), "CEC MARCONI", "STR. MARCONI, INTRE C.VICTORIEI SI STR. ILFOV", 5m, 30 },
                    { 147, 33, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4021), "CALEA PLEVNEI", "CALEA PLEVNEI", 5m, 33 },
                    { 161, 138, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4496), "CHIRISTIGIILOR", "STR. CHIRISTIGIILOR, CF. AVIZ CTC NR. 11987/05.08.2010", 2.5m, 138 },
                    { 131, 82, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3474), "BISERICA ENEI", "INTRE STR. ACADEMIEI SI STR. EDGAR QUINET", 10m, 82 },
                    { 129, 89, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3410), "GENERAL BERTHELOT 3", "INTRE STR. POPA TATU SI STR. BERZEI", 5m, 89 },
                    { 101, 29, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2250), "Alee Legatura Banu Antonache si Calea Floreasca", "", 2.5m, 29 },
                    { 102, 8, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2420), "ALEEA CAUZASI", "INTERSECTIA CU BD. MIRCEA VODA", 5m, 8 },
                    { 103, 59, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2464), "ALEEA PRIVIGHETORILOR 1", "INTRE AL.PRIVIGHETORILOR SI SERBAN CANTACUZINO", 2.5m, 59 },
                    { 104, 56, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2498), "ALEXANDRU BELDIMAN", "INTRE BD. REGINA ELISABETA SI STR. EFORIE", 5m, 56 },
                    { 105, 153, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2534), "ALEXANDRU CONSTANTINESCU", "INTRE BD. MARASESTI SI BD. ION MIHALACHE", 2.5m, 153 },
                    { 106, 57, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2569), "ALEXANDRU IOAN CUZA 1", "INTRE GH. DUCA SI DR. I. FELIX", 5m, 57 },
                    { 107, 47, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2599), "ALEXANDRU IOAN CUZA 2", "INTRE GH. DUCA SI C-TIN DISESCU", 5m, 47 },
                    { 108, 76, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2632), "ALEXANDRU IOAN CUZA 3", "INTRE SOS. N.TITULESCU SI STR. C-TIN DISESCU", 5m, 76 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 109, 7, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2666), "ARISTIDE DEMETRIADE", "INTRE STR. BREZOIANU SI STR. GEORGE VRACA", 5m, 7 },
                    { 110, 41, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2747), "PICTOR ARTHUR VERONA", "STR. PICTOR VERONA, INTRE BD. MAGHERU SI STR. PITAR MOS", 5m, 41 },
                    { 111, 70, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2783), "ARTHUR VERONA 2", "INTRE PITAR MOS SI J.L.CALDERON", 5m, 70 },
                    { 112, 223, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2817), "AVIATORILOR 1D", "INTRE ROND PESCARUS SI PIATA CHARLES DE GAULLE", 5m, 223 },
                    { 113, 181, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2850), "AVIATORILOR 1S", "INTRE ROND PESCARUS SI PIATA CHARLES DE GAULLE", 5m, 181 },
                    { 130, 59, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3444), "BIBESCU VODA", "INTRE SP. INDEPENDENTEI SI BD. D. CANTEMIR", 5m, 59 },
                    { 114, 175, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2883), "AVIATORILOR 2D", "INTRE PIATA CHARLES DE GAULLE SI GH. DEMETRIADE", 5m, 175 },
                    { 116, 85, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2947), "AVIATORILOR 3S", "INTRE PIATA VICTORIEI SI STR. CAPITAN GHE. DEMETRIADE", 5m, 85 },
                    { 117, 145, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2980), "AVRIG 1", "INTRE BD. FERDINAND SI STR. CHIRISTIGIILOR", 2.5m, 145 },
                    { 118, 159, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3014), "AVRIG 2", "INTRE SOS. IANCULUI SI STR. RITMULUI", 2.5m, 159 },
                    { 119, 23, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3046), "BALANESCU ROSETTI", "INTRE CALEA FLOREASCA SI STR. BANUL ANTONACHE", 2.5m, 23 },
                    { 120, 65, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3079), "BANU MANTA 1", "INTRE STR. G-RAL VLADOIANU BARBU SI STR. FROSA SARANDY", 2.5m, 65 },
                    { 121, 65, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3110), "BANU MANTA 2", "INTRE STR. FROSA SARANDY SI BD. I. MIHALACHE", 2.5m, 65 },
                    { 122, 126, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3142), "BANUL ANTONACHE", "", 2.5m, 126 },
                    { 123, 68, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3173), "BARBU DELAVRANCEA", "INTRE BD. ION MIHALACHE SI STR. ION MINCU", 5m, 68 },
                    { 124, 495, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3205), "BASARABIA 1", "INTRE PIATA MUNCII SI BD. CHISINAU", 2.5m, 495 },
                    { 125, 58, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3274), "BATISTEI", "INTRE BD. NICOLAE BALCESCU SI STR. I.L.CARAGIALE", 10m, 58 },
                    { 126, 22, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3313), "BCU – BIBLIOTECA CENTRALA UNIVERSITARA", "STR. DEM. I. DOBRESCU, INTRE CALEA VICTORIEI SI STR. BOTEANU", 5m, 22 },
                    { 127, 36, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3346), "GENERAL BERTHELOT", "INTRE STR. L.CAZAVILLIAN SI STR. POPA TATU", 5m, 36 },
                    { 128, 57, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(3379), "GENERAL BERTHELOT 2", "INTRE STR. LUTERANA SI CALEA VICTORIEI", 5m, 57 },
                    { 115, 181, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(2914), "AVIATORILOR 2S", "INTRE PTA CHARLES DE GAULLE SI STR. GH. DEMETRIADE", 5m, 181 },
                    { 352, 12, "București", new DateTime(2021, 7, 12, 11, 12, 41, 445, DateTimeKind.Local).AddTicks(1344), "CONSTANTIN ESARCU", "INTRE STR. EPISCOPIEI SI STR. NICOLAE GOLESCU", 5m, 12 },
                    { 162, 21, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4528), "CHRISTIAN TELL", "INTRE STR. BISERICA AMZEI SI PIATA AMZEI", 5m, 21 },
                    { 164, 72, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4592), "CINA 2", "INTRE STR. B. FRANKLIN SI STR. EPISCOPIEI", 5m, 72 },
                    { 197, 93, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5761), "FICUSULUI 2", "INTRE STR. H.MACELARIU SI BD. AEROGARII", 2.5m, 93 },
                    { 198, 152, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5794), "FRUMOASA", "INTRE CALEA VICTORIEI SI STR. SEVASTOPOL", 5m, 152 },
                    { 199, 119, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5828), "GARA BANEASA", "ESPLANADA GARII BANEASA SI STR. TIPOGRAFILOR", 5m, 119 },
                    { 200, 13, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5861), "GARA CEAS", "PIATA GARII DE NORD", 5m, 13 },
                    { 201, 39, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5892), "GARA PARC", "PIATA GARII DE NORD", 5m, 39 },
                    { 202, 25, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5925), "GARII DE NORD 1", "STR. GARII DE NORD, INTRE STR. BERZEI SI STR. CAMELIEI", 2.5m, 25 },
                    { 203, 77, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6017), "GARII DE NORD 2", "STR. GARII DE NORD, INTRE STR. CAMELIEI SI PTA. GARII DE NORD", 2.5m, 77 },
                    { 204, 147, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6052), "GEORGE CALINESCU", "", 2.5m, 147 },
                    { 205, 35, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6085), "GEORGE ENESCU", "STR. GEORGE ENESCU, INTRE STR. MENDELEEV SI BD. MAGHERU", 5m, 35 },
                    { 206, 65, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6118), "GEORGE ENESCU 3", "INTRE STR. D.I.MENDELEEV SI CALEA VICTORIEI", 5m, 65 },
                    { 207, 54, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6149), "GHEORGHE DUCA", "INTRE CALEA GRIVITEI SI A.I.CUZA", 2.5m, 54 },
                    { 208, 46, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6183), "GHEORGHE LAZAR", "INTRE SF. CONSTANTIN SI GH.COBALCESCU", 2.5m, 46 },
                    { 209, 31, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6215), "GRADINA CU CAI", "INTRE SP. INDEPENDENTEI SI PTA. M.KOGALNICEANU", 5m, 31 },
                    { 196, 46, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5730), "FICUSULUI 1", "INTRE STR. E.VACARESCU SI STR. H.MACELARIU", 2.5m, 46 },
                    { 210, 30, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6248), "GRADINITA – ROSETTI", "STR. C.A.ROSETTI, INTRE STR. T. ARGHEZI SI STR. DAVID PRAPORGESCU", 10m, 30 },
                    { 212, 216, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6311), "GRIGORE ALEXANDRESCU 2", "INTRE BD. LASCAR CATARGIU SI CALEA DOROBANTI", 5m, 216 },
                    { 213, 118, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6342), "GRIGORE COBALCESCU", "INTRE BD. SCHITU MAGUREANU SI STR. BERZEI", 5m, 118 },
                    { 214, 82, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6374), "GUTENBERG", "", 2.5m, 82 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[,]
                {
                    { 215, 15, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6406), "HALELOR", "STR. HALELOR, INTRE STR. SELARI SI STR. CALDARARI", 10m, 15 },
                    { 216, 99, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6437), "HERASTRAU 1 (PAVILION H)", "PARC HERASTRAU", 5m, 99 },
                    { 217, 132, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6468), "HERASTRAU 2 BOA", "PARC MIORITA (HERASTRAU)", 5m, 132 },
                    { 218, 14, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6501), "HOROSCOP 1", "BD. D. CANTEMIR - INTRE SPLAIUL UNIRII SI STR. BIBESCU VODA", 5m, 14 },
                    { 219, 11, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6597), "HOROSCOP 2 SITRACO", "BD. D. CANTEMIR - INTRE SPLAIUL UNIRII SI STR. BIBESCU VODA", 5m, 11 },
                    { 220, 24, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6637), "HOROSCOP 3 SPLAI", "BD. D. CANTEMIR - SPLAIUL UNIRII", 5m, 24 },
                    { 221, 20, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6669), "HRISTO BOTEV 1", "INTRE STR. SCAUNE SI STR. IVO ANDRIC", 5m, 20 },
                    { 222, 25, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6701), "HRISTO BOTEV 2", "INTRE STR. NEGUSTORI SI STR. TEODOR STEFANESCU", 5m, 25 },
                    { 223, 91, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6732), "IACOB FELIX 1", "INTRE STR. GHE. POLIZU SI SOS. N. TITULESCU", 2.5m, 91 },
                    { 224, 33, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6766), "IACOB FELIX 2", "INTRE SOS. N. TITULESCU SI BD. I. MIHALACHE", 2.5m, 33 },
                    { 211, 41, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(6278), "GRIGORE ALEXANDRESCU", "STR. GRIGORE ALEXANDRESCU, INTRE CALEA VICTORIEI SI BD. LASCAR CATARGIU", 5m, 41 },
                    { 163, 126, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4557), "CINA", "INTRE STR. C.A. ROSETTI SI STR. B. FRANKLIN", 5m, 126 },
                    { 195, 188, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5695), "EXPOZITIEI", "BD. EXPOZITIEI (ZONA ROMEXPO)", 5m, 188 },
                    { 193, 77, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5633), "EPISCOPIEI", "INTRE N.GOLESCU SI C. VICTORIEI", 5m, 77 },
                    { 165, 35, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4625), "CLOPOTARII VECHI", "INTRE STR. GRIGORE ALEXANDRESCU SI BD. IANCU DE HUNEDOARA", 5m, 35 },
                    { 166, 54, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4657), "CONSERVATOR – UNESCO", "STR. STIRBEI VODA", 5m, 54 },
                    { 167, 84, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4688), "CONSTANTIN MILLE", "INTRE CALEA VICTORIEI SI STR. I. BREZOIANU", 5m, 84 },
                    { 168, 33, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4721), "CONSTANTIN NACU", "INTRE PTA. ITALIANA SI BD. CAROL I", 5m, 33 },
                    { 169, 92, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4751), "CRANGASI", "PTA. CRANGASI", 2.5m, 92 },
                    { 170, 36, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4785), "CRETULESCU", "ALEEA DE LANGA BISERICA CRETULESCU", 5m, 36 },
                    { 171, 40, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4875), "DACIA 2", "BD. DACIA", 5m, 40 },
                    { 172, 21, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4909), "DACIA MONTEORU", "BD. DACIA X CALEA VICTORIEI", 5m, 21 },
                    { 173, 69, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4941), "DANIELOPOL", "INTRE SPLAIUL INDEPENDENTEI SI STR. POENARU BORDEA", 5m, 69 },
                    { 174, 64, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(4974), "DECEBAL 1", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 64 },
                    { 175, 44, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5005), "DECEBAL 2", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 44 },
                    { 176, 53, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5037), "DECEBAL 3", "CALEA MOSILOR (PTA. DECEBAL)", 10m, 53 },
                    { 177, 67, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5068), "DIANEI", "INTRE ITALIANA SI CAROL I", 5m, 67 },
                    { 194, 73, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5665), "EVA", "BD. GHE. MAGHERU, INTRE STR. G.ENESCU SI STR. ANASTASIE SIMU", 5m, 73 },
                    { 178, 72, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5101), "DINICU GOLESCU (GARA)", "", 2.5m, 72 },
                    { 180, 120, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5165), "DIONISIE LUPU", "INTRE STR. G-RAL EREMIA GRIGORESCU SI C.A.ROSETTI", 5m, 120 },
                    { 181, 18, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5198), "DOAMNEI 1", "STR. DOAMNEI, INTRE BD. I.C.BRATIANU SI INTR. SELARI", 10m, 18 },
                    { 182, 21, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5231), "DOAMNEI 2", "", 10m, 21 },
                    { 183, 28, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5263), "DOAMNEI 4", "", 10m, 28 },
                    { 184, 57, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5296), "DOMNITA ANASTASIA", "INTRE STR. LIPSCANI SI STR. A. SALIGNY", 5m, 57 },
                    { 185, 21, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5327), "DOROBANTI", "PTA. DOROBANTI", 5m, 21 },
                    { 186, 11, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5359), "DOROBANTI – LAHOVARI", "", 5m, 11 },
                    { 187, 11, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5436), "DOROBANTI DACIA", "INTERSECTIE BD. DACIA SI CALEA DOROBANTILOR", 5m, 11 },
                    { 188, 19, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5472), "DRISTOR 1", "INTRE C.RESSU SI STATIE METROU", 2.5m, 19 },
                    { 189, 21, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5504), "DRISTOR 2", "INTRE STATIE METROU SI GRAULUI", 2.5m, 21 },
                    { 190, 107, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5536), "EDGAR QUINET", "INTRE CALEA VICTORIEI SI BISERICA ENEI", 10m, 107 },
                    { 191, 48, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5569), "EFORIE", "INTRE C.VICTORIEI SI STR. D. ANASTASIA", 5m, 48 },
                    { 192, 64, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5602), "ELENA VACARESCU", "INTRE BD. FICUSULUI SI SOS. BUCURESTI-PLOIESTI", 2.5m, 64 }
                });

            migrationBuilder.InsertData(
                table: "ParkingAreas",
                columns: new[] { "Id", "AvailableSpots", "City", "CreatedOn", "Emplacement", "EmplacementLocation", "PricePerHour", "TotalSpots" },
                values: new object[] { 179, 111, "București", new DateTime(2021, 7, 12, 11, 12, 41, 444, DateTimeKind.Local).AddTicks(5131), "DINICU GOLESCU 1", "INTRE STR. M. VULCANESCU SI PTA. GARII DE NORD", 2.5m, 111 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 1, new DateTime(2021, 7, 12, 11, 12, 41, 360, DateTimeKind.Local).AddTicks(3960), "administrator220@easypark.com", "ADMINISTRATOR", "superadministrator", "0723678956", 220 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 342);

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
        }
    }
}
