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
        public string ReservationDate { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }

        public NewVehicleDto Vehicle { get; set; }
    }
}
