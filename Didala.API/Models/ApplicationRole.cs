using System;
using Microsoft.AspNetCore.Identity;

namespace Didala.API.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        public string AreaUsed { get; set; }
    }
}
