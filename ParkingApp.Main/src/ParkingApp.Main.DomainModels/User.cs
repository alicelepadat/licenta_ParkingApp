using System.ComponentModel.DataAnnotations;
using ParkingApp.Main.Common.Enums;

namespace ParkingApp.Main.DomainModels
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(12)]
        public string Phone { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UserRoleEnum Role { get; set; } = UserRoleEnum.DRIVER;
    }
}
