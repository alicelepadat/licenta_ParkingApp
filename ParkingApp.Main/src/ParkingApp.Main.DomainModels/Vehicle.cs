using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.DomainModels
{
    public class Vehicle : BaseEntity
    {
        [Required]
        [MaxLength(7)]
        public string LicensePlate { get; set; }

        public Driver Driver { get; set; }

        public int? DriverId { get; set; }

        public Reservation DriverReservation { get; set; }
    }
}
