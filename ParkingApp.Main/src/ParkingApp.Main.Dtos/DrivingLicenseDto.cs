using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class DrivingLicenseDto
    {
        public int Id { get; set; }


        [MaxLength(12)]
        public string Number { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DriverDto Driver { get; set; }
    }
}