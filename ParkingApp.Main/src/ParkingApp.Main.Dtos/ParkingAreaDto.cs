using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class ParkingAreaDto
    {
        public int Id { get; set; }

        [Required]
        public string Emplacement { get; set; }
        
        [Required]
        public int TotalSpots { get; set; }
        
        public int? AvailableSpots { get; set; }

        [RegularExpression(@"^\d{1,3}(\.\d{1,2})?$", ErrorMessage = "Pretul nu este valid.")]
        public decimal PricePerHour { get; set; }
        
        [Required]
        public string City { get; set; }
        
        public string EmplacementLocation { get; set; }

        public AdminDto Admin { get; set; }
    }
}