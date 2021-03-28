using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class VehicleDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(7)]
        public string LicensePlate { get; set; }

        public DriverDto Driver { get; set; }

        public NewReservationDto DriverReservation { get; set; }
    }
}