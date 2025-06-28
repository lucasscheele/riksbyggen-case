using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riksbyggen.Backend.Data;
using Riksbyggen.Backend.Models;

namespace Riksbyggen.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApartmentController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Apartment>>> GetApartmentsForCompany(int companyId)
        {
            var apartments = await context.Apartments
                .Where(x => x.CompanyId == companyId)
                .ToListAsync();

            return Ok(apartments);
        }

        
    }
}
