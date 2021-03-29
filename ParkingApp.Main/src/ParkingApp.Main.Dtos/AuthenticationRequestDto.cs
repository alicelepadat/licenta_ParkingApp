using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class AuthenticationRequestDto
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
