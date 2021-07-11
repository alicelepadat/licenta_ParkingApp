using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ParkingApp.Main.Dtos
{
    public class DriverDto
    {
        public int Id { get; set; }

        [Required]
        public UserDto User { get; set; }

        public DrivingLicenseDto License { get; set; }

        [JsonIgnore]
        public List<VehicleDto> Vehicles { get; set; }
    }
}