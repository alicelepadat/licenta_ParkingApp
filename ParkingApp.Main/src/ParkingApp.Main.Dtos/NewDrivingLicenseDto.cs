using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class NewDrivingLicenseDto
    {
        [MaxLength(12)]
        public string Number { get; set; }

        public string ExpirationDate { get; set; }
    }
}