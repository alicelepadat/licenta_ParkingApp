using System;
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
        private static readonly string file = @"C:\facultate\ParkingApp\ParkingApp.Main\src\ParkingApp.Main.Common\Files\lista_parcari.xlsx";
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

            var user = new User
            {
                Id = 3,
                CreatedOn = DateTime.Now,
                Name = "ADMIN_AREA342",
                Email = "admin_area342@easypark.com",
                Phone = "0734670055",
                Password = BC.HashPassword("admin_area342"),
                Role = UserRoleEnum.ADMIN
            };


            builder.Entity<User>().HasData(administrator);
            builder.Entity<User>().HasData(user);

            var admin = new Admin
            {
                Id = 1,
                CreatedOn = DateTime.Now,
                UserId = user.Id,
                ParkingAreaId = 342
            };

            builder.Entity<Admin>().HasData(admin);

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
