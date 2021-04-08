using ExcelDataReader;
using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Geocoding;
using Geocoding.Google;
using Address = ParkingApp.Main.DomainModels.Address;

namespace ParkingApp.Main.DataAcces
{
    public static class DbSeedExtension
    {
        private static readonly string file = @"..\ParkingApp.Main.Common\Files\PublicParkingSpots.xlsx";
        private static IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyDwfCFbPjHTY1L7Dttpv4780198igxbiEI" };
        private static Company company;
        private static int id = 2;

        public static void SeedDatabase(this ModelBuilder builder)
        {

            company = new Company {
                Id = 1,
                CreatedOn = DateTime.Now,
                CompanyName = "Administrația Străzilor București"
            };

            builder.Entity<Company>().HasData(company);

            ImportAsync(builder, file);
        }

        private static async Task<IEnumerable<Geocoding.Address>> getCoordinates(string address)
        {
            return await geocoder.GeocodeAsync(address);
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
                var address = new Address
                {
                    Id = id,
                    City = dataTable.Rows[row][4].ToString(),
                    Street = dataTable.Rows[row][5].ToString(),
                    Directions = dataTable.Rows[row][6].ToString(),
                    CoordinatesId = null,
                    County = dataTable.Rows[row][7].ToString(),
                    CreatedOn = DateTime.Now
                };

                var coordinates = getCoordinates(address.Street);
                var addressCoord = new Coordinates
                {
                    Id = id,
                    Latitude = coordinates.Result.First().Coordinates.Latitude,
                    Longitude = coordinates.Result.First().Coordinates.Longitude
                };

                address.CoordinatesId = addressCoord.Id;

                var parkingArea = new ParkingArea
                {
                    Id = id,
                    TotalSpots = Int32.Parse(dataTable.Rows[row][1].ToString()),
                    AvailableSpots = Int32.Parse(dataTable.Rows[row][2].ToString()),
                    PricePerHour = Decimal.Parse(dataTable.Rows[row][3].ToString()),
                    AddressId = address.Id,
                    CompanyId = company.Id,
                    CreatedOn = DateTime.Now
                };
                id += 1;

                builder.Entity<Coordinates>().HasData(addressCoord);
                builder.Entity<Address>().HasData(address);

                builder.Entity<ParkingArea>().HasData(parkingArea);
            }
        }
    }
}
