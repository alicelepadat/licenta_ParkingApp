using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class NewUserDto
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(12)]
        public string Phone { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
