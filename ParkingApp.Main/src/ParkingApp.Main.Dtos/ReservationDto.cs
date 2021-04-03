using ParkingApp.Main.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }
        
        [Required]
        public DateTime ReservationDate { get; set; }
        
        [Required]
        public DateTime StartTime{ get; set; }

        [Required] 
        public DateTime EndTime { get; set; }

        public ReservationStateEnum State { get; set; }

        public VehicleDto Vehicle { get; set; }

        public ParkingAreaDto ParkingArea { get; set; }
    }
}