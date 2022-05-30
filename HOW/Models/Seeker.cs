using System;
using System.Collections.Generic;

namespace HOW
{
    public partial class Seeker
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        /*[Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(16,200,ErrorMessage = "Age cannot be less than 16")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Input should be a valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(30,ErrorMessage = "Password cannot be greater than 30")]
        public string Password { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required")]
        public string PhoneNumber { get; set; }*/
    }
}
