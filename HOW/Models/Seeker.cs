using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HOW
{
    public partial class Seeker
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; } = null!;
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; } = null!;
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Input shoulde be of Email type")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "PhoneNumber is required")]
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
