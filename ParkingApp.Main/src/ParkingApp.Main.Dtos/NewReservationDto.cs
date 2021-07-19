using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
