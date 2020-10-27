using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Didala.API
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlConnection"));
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Models.ApplicationUser> userManager { get; set; }
        //public DbSet<Models.SearchModel> searchModels { get; set; }
        //public DbSet<Models.RegisterModel> registerModels { get; set; }
        //public DbSet<Models.LoginModel> loginModels { get; set; }
        public DbSet<Models.Offerings> Offering { get; set; }
    }
}
