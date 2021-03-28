using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Main.Dtos
{
    public class NewReservationDto
    {
        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public NewVehicleDto Vechicle { get; set; }

        public ParkingAreaDto ParkingArea { get; set; }
    }
}
