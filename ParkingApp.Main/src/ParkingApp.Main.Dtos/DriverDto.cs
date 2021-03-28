using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class DriverDto
    {
        public int Id { get; set; }

        [Required]
        public UserDto User { get; set; }

        public DrivingLicenseDto License { get; set; }

        public List<VehicleDto> Vehicles { get; set; }
    }
}