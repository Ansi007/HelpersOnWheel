using System.ComponentModel.DataAnnotations;

namespace HOW.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage = "Input should be a valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}
