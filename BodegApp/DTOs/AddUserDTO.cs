using System.ComponentModel.DataAnnotations;

namespace BodegApp.DTOs
{
    public class AddUserDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "The password must be at least 8 characters long.")]
        public string Password { get; set; }
    }
}
