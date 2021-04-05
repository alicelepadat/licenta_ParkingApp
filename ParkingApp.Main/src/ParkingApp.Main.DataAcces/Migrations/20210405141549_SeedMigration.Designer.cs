﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingApp.Main.DataAcces;

namespace ParkingApp.Main.DataAcces.Migrations
{
    [DbContext(typeof(ParkingMainContext))]
    [Migration("20210405141549_SeedMigration")]
    partial class SeedMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("CoordinatesId")
                        .HasColumnType("int");

                    b.Property<string>("County")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Directions")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Street")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatesId")
                        .IsUnique()
                        .HasFilter("[CoordinatesId] IS NOT NULL");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            City = "Bucuresti",
                            CoordinatesId = 2,
                            County = "Sector 1",
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 45, 701, DateTimeKind.Local).AddTicks(422),
                            Directions = "Între bd. Regina Elisabeta și I. Campineanu",
                            Street = "Academiei"
                        },
                        new
                        {
                            Id = 3,
                            City = "Bucuresti",
                            CoordinatesId = 3,
                            County = "Sector 1",
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 46, 734, DateTimeKind.Local).AddTicks(891),
                            Directions = "",
                            Street = "Alee Legatura Banu Antonache si Calea Floreasca"
                        },
                        new
                        {
                            Id = 4,
                            City = "Bucuresti",
                            CoordinatesId = 4,
                            County = "Sector 3",
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 47, 253, DateTimeKind.Local).AddTicks(9482),
                            Directions = "INTERSECTIA CU BD. MIRCEA VODA",
                            Street = "ALEEA CAUZASI"
                        },
                        new
                        {
                            Id = 5,
                            City = "Bucuresti",
                            CoordinatesId = 5,
                            County = "Sector 1",
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 47, 710, DateTimeKind.Local).AddTicks(2549),
                            Directions = "INTRE AL.PRIVIGHETORILOR SI SERBAN CANTACUZINO",
                            Street = "ALEEA PRIVIGHETORILOR"
                        },
                        new
                        {
                            Id = 6,
                            City = "Bucuresti",
                            CoordinatesId = 6,
                            County = "Sector 5",
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 48, 78, DateTimeKind.Local).AddTicks(1962),
                            Directions = "",
                            Street = "ALEXANDRU BELDIMAN"
                        });
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParkingAreaId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ParkingAreaId")
                        .IsUnique()
                        .HasFilter("[ParkingAreaId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Administrația Străzilor București",
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 45, 383, DateTimeKind.Local).AddTicks(5032)
                        });
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Coordinates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 44.437579499999998,
                            Longitude = 26.0980755
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 44.461201299999999,
                            Longitude = 26.099996600000001
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 44.427555900000002,
                            Longitude = 26.113038800000002
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 44.516416100000001,
                            Longitude = 26.091535700000001
                        },
                        new
                        {
                            Id = 6,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 44.4343279,
                            Longitude = 26.097335300000001
                        });
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("LicenseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LicenseId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.DrivingLicense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IssuerId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("IssuerId")
                        .IsUnique();

                    b.ToTable("DrivingLicense");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Issuer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("Issuer");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.ParkingArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableSpots")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("PricePerHour")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("TotalSpots")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("CompanyId");

                    b.ToTable("ParkingAreas");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            AvailableSpots = 96,
                            CompanyId = 1,
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 46, 733, DateTimeKind.Local).AddTicks(9237),
                            PricePerHour = 0m,
                            TotalSpots = 96
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            AvailableSpots = 29,
                            CompanyId = 1,
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 47, 253, DateTimeKind.Local).AddTicks(8997),
                            PricePerHour = 0m,
                            TotalSpots = 29
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 4,
                            AvailableSpots = 8,
                            CompanyId = 1,
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 47, 710, DateTimeKind.Local).AddTicks(2037),
                            PricePerHour = 0m,
                            TotalSpots = 8
                        },
                        new
                        {
                            Id = 5,
                            AddressId = 5,
                            AvailableSpots = 59,
                            CompanyId = 1,
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 48, 78, DateTimeKind.Local).AddTicks(1298),
                            PricePerHour = 0m,
                            TotalSpots = 59
                        },
                        new
                        {
                            Id = 6,
                            AddressId = 6,
                            AvailableSpots = 56,
                            CompanyId = 1,
                            CreatedOn = new DateTime(2021, 4, 5, 17, 15, 48, 576, DateTimeKind.Local).AddTicks(6523),
                            PricePerHour = 0m,
                            TotalSpots = 56
                        });
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParkingAreaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParkingAreaId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Address", b =>
                {
                    b.HasOne("ParkingApp.Main.DomainModels.Coordinates", "Coordinates")
                        .WithOne("Address")
                        .HasForeignKey("ParkingApp.Main.DomainModels.Address", "CoordinatesId");

                    b.Navigation("Coordinates");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Admin", b =>
                {
                    b.HasOne("ParkingApp.Main.DomainModels.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkingApp.Main.DomainModels.ParkingArea", "ParkingArea")
                        .WithOne("Admin")
                        .HasForeignKey("ParkingApp.Main.DomainModels.Admin", "ParkingAreaId");

                    b.HasOne("ParkingApp.Main.DomainModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("ParkingArea");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Driver", b =>
                {
                    b.HasOne("ParkingApp.Main.DomainModels.DrivingLicense", "License")
                        .WithOne("Driver")
                        .HasForeignKey("ParkingApp.Main.DomainModels.Driver", "LicenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkingApp.Main.DomainModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("License");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.DrivingLicense", b =>
                {
                    b.HasOne("ParkingApp.Main.DomainModels.Issuer", "Issuer")
                        .WithOne("DrivingLicense")
                        .HasForeignKey("ParkingApp.Main.DomainModels.DrivingLicense", "IssuerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issuer");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.ParkingArea", b =>
                {
                    b.HasOne("ParkingApp.Main.DomainModels.Address", "Address")
                        .WithOne("ParkingArea")
                        .HasForeignKey("ParkingApp.Main.DomainModels.ParkingArea", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkingApp.Main.DomainModels.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Reservation", b =>
                {
                    b.HasOne("ParkingApp.Main.DomainModels.ParkingArea", "ParkingArea")
                        .WithMany()
                        .HasForeignKey("ParkingAreaId");

                    b.HasOne("ParkingApp.Main.DomainModels.Vehicle", "Vehicle")
                        .WithMany("DriverReservations")
                        .HasForeignKey("VehicleId");

                    b.Navigation("ParkingArea");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Vehicle", b =>
                {
                    b.HasOne("ParkingApp.Main.DomainModels.Driver", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("DriverId");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Address", b =>
                {
                    b.Navigation("ParkingArea");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Coordinates", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Driver", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.DrivingLicense", b =>
                {
                    b.Navigation("Driver");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Issuer", b =>
                {
                    b.Navigation("DrivingLicense");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.ParkingArea", b =>
                {
                    b.Navigation("Admin");
                });

            modelBuilder.Entity("ParkingApp.Main.DomainModels.Vehicle", b =>
                {
                    b.Navigation("DriverReservations");
                });
#pragma warning restore 612, 618
        }
    }
}
