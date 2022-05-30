using System.ComponentModel.DataAnnotations;

namespace HOW.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Input shoulde be of Email type")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
    }
}
