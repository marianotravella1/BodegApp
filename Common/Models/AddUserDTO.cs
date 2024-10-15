using System.ComponentModel.DataAnnotations;

namespace BodegApp.Models.DTOs
{
    public class AddUserDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
