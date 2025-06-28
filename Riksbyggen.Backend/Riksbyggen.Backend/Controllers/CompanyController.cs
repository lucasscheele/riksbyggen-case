using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riksbyggen.Backend.Data;
using Riksbyggen.Backend.Models;

namespace Riksbyggen.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            var companies = await context.Companies.ToListAsync();
            return Ok(companies);
        }
    }
}
