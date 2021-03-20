using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.DomainModels
{
    public class Issuer : BaseEntity
    {
        [Required]
        [MaxLength(400)]
        public string Name { get; set; }

        public DrivingLicense DrivingLicense { get; set; }
    }
}