using System;
using System.ComponentModel.DataAnnotations;

namespace Didala.Models.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "First name is required")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]

        public string LastName { get; set; }

        public string AlternateEmailAddress { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Location name is required")]

        public string Location { get; set; }

        [Required(ErrorMessage = "Class name is required")]

        public string Class { get; set; }
        [Required(ErrorMessage = "Category is required")]

        public string Category { get; set; }
        public string FacebookUserName { get; set; }
        public string TwitterUserName { get; set; }
        public string InstagramUserName { get; set; }
        public string GoogleUserName { get; set; }
        public string LinkedInUserName { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]

        public DateTime DateOfBirth { get; set; }

    }
}
