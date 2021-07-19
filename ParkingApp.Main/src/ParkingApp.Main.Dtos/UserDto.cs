using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ParkingApp.Main.Common.Enums;

namespace ParkingApp.Main.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

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
        
        public UserRoleEnum Role { get; set; } = UserRoleEnum.DRIVER;


        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}