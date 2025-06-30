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

        [HttpGet]
        [Route("expiring-contracts")]
        public async Task<ActionResult<IEnumerable<Apartment>>> GetApartmentsWithExpiringContracts(int companyId)
        {
            var apartments = await context.Apartments
                .Where(x => x.CompanyId == companyId)
                .Include(x => x.Contracts)
                .ToListAsync();


            if (apartments.Count == 0)
            {
                return NotFound("No apartments found for company");
            }

            var currentDate = DateTime.Now.Date;

            var apartmentsWithExpiringContracts = apartments.Where(
                apartment => apartment.Contracts.Any(
                    contract =>
                     contract.EndDate > currentDate &&
                     contract.EndDate < currentDate.AddMonths(3)
                ));
           
            return Ok(apartmentsWithExpiringContracts);
        }
    }
}
