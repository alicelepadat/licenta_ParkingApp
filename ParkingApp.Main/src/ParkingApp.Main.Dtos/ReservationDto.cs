using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }

        [Required]
        public DateTime ReservationTime { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        [Range(30, 24 * 60)]
        public int Duration { get; set; }

        [Required]
        public bool Finished { get; set; }

        public VehicleDto Vechicle { get; set; }

        public ParkingAreaDto ParkingArea { get; set; }
    }
}