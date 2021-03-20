using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class IssuerDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(400)]
        public string Name { get; set; }

        public DrivingLicenseDto DrivingLicense { get; set; }
    }
}