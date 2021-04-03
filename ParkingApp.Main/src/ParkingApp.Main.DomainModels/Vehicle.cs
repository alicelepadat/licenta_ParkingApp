using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.DomainModels
{
    public class Vehicle : BaseEntity
    {
        [Required]
        [MaxLength(7)]
        public string LicensePlate { get; set; }
        
        public int? DriverId { get; set; }

        public List<Reservation> DriverReservations { get; set; }
    }
}
