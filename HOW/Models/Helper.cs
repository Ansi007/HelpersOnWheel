using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HOW.Models
{
    public partial class Helper
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
        [Required(ErrorMessage = "Profession is required")]
        public string Profession { get; set; } = null!;
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; } = null!;
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = null!;
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = null!;
        [Required(ErrorMessage = "Zip is required")]
        public int Zip { get; set; }
    }

    /*        
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(16,200,ErrorMessage = "Age cannot be less than 16 or greater than 200")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Profession is required")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Input should be a valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [Phone(ErrorMessage ="Please Enter a Valid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Zip is required")]
        public int Zip { get; set; }*/
}
