using System.ComponentModel.DataAnnotations;

namespace DatingApp.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string KnownAs { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; } //optional for required to work
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
