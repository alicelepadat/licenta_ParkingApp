using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class AuthenticationRequestDto
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
