using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class DrivingLicenseDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(12)]
        public string Number { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        public DriverDto Driver { get; set; }
    }
}