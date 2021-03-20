using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.DomainModels
{
    public class Driver : BaseEntity
    {
        [Required]
        public User User { get; set; }

        public int UserId { get; set; }

        public DrivingLicense License { get; set; }

        public int LicenseId { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}
