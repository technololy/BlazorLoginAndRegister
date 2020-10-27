using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Didala.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Didala.API.Controllers
{
    public class CoreActivitiesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext context;

        public CoreActivitiesController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            this.context = context;
        }

        [HttpPost]
        [Route("Search")]
        public async Task<IActionResult> Search([FromBody] SearchModel model)
        {
            try
            {
                var result = await context.Offering.Where(x => Convert.ToInt32(x.MinPrice) >= Convert.ToInt32(model.MinPrice) || Convert.ToInt32(x.MaxPrice) <= Convert.ToInt32(model.MaxPrice)).ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return BadRequest(ex);
            }
        }
    }
}
