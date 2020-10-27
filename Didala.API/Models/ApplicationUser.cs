﻿using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace Didala.API.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required(ErrorMessage = "First name is required")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]

        public string LastName { get; set; }

        public string AlternateEmailAddress { get; set; }

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

        public Offerings offering { get; set; }

        public ApplicationUser()
        {
        }
    }
}
