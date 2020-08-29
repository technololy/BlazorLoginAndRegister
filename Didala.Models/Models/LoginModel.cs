using System;
using System.ComponentModel.DataAnnotations;

namespace Didala.Models.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }

    public class LoginResponse
    {
        public string Token { get; set; }

        public DateTimeOffset Expiration { get; set; }

        public bool IsSuccessful { get; set; }
    }
}
