﻿using System;
using System.Collections.Generic;
using System.IO;
using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.Common.Enums;
using ParkingApp.Main.DomainModels;
using BC = BCrypt.Net.BCrypt;


namespace ParkingApp.Main.DataAcces
{
   public static class DbSeedExtension
    {
        private static readonly string file = @"..\ParkingApp.Main.Common\Files\lista_parcari.xlsx";
        private static int id = 100;

        public static void SeedDatabase(this ModelBuilder builder)
        {
            var administrator = new User {
                Id = 1,
                CreatedOn = DateTime.Now,
                Name = "ADMINISTRATOR",
                Email = "administrator220@easypark.com",
                Phone = "0723678956",
                Password = BC.HashPassword("superadministrator"),
                Role = UserRoleEnum.ADMINISTRATOR
            };

            builder.Entity<User>().HasData(administrator);

            ImportAsync(builder, file);
        }

        private static void ImportAsync(ModelBuilder builder, string filename)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using var stream = File.OpenRead(filename);
            using var reader = ExcelReaderFactory.CreateReader(stream);

            var dataSet = reader.AsDataSet();
            var dataTable = dataSet.Tables[0];

            for (var row = 1; row < dataTable.Rows.Count; row++)
            {
                var area = new ParkingArea
                {
                    Id = id,
                    CreatedOn = DateTime.Now,
                    Emplacement = dataTable.Rows[row][0].ToString(),
                    TotalSpots = Int32.Parse(dataTable.Rows[row][1].ToString()),
                    AvailableSpots = Int32.Parse(dataTable.Rows[row][1].ToString()),
                    EmplacementLocation = dataTable.Rows[row][2].ToString(),
                    City = dataTable.Rows[row][3].ToString(),
                    PricePerHour = Decimal.Parse(dataTable.Rows[row][4].ToString())
                };

                id++;
                
                builder.Entity<ParkingArea>().HasData(area);
            }
        }
    }
}
