using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class NewDrivingLicenseDto
    {
        [Required]
        [MaxLength(12)]
        public string Number { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        public NewIssuerDto Issuer { get; set; }
    }
}