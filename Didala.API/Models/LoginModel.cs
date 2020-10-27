using System;
using System.ComponentModel.DataAnnotations;

namespace Didala.API.Models
{
    public class LoginModel
    {
        public int LoginId { get; set; }
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
