using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingApp.Main.DomainModels
{
    public class ParkingArea : BaseEntity
    {
        [Required]
        public string Emplacement { get; set; }
        
        [Required]
        public int TotalSpots { get; set; }

        public int? AvailableSpots { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal PricePerHour { get; set; }

        [Required]
        public string City { get; set; }
        
        public string EmplacementLocation { get; set; }
        
        public Admin Admin { get; set; }

    }
}
