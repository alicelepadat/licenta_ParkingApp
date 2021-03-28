using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingApp.Main.DomainModels
{
    public class Reservation : BaseEntity
    {
        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public DateTime StartTime{ get; set; }
        
        [Required]
        public DateTime EndTime{ get; set; }
        
        [Required]
        [Column(TypeName = "bit")]
        public bool Finished { get; set; }

        public Vehicle Vechicle { get; set; }

        public int VehicleId { get; set; }

        public ParkingArea ParkingArea { get; set; }

        public int ParkingAreaId { get; set; }
    }
}
