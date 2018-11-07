using System.ComponentModel.DataAnnotations;

namespace Habitual.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}