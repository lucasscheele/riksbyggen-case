using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riksbyggen.Backend.Data;
using Riksbyggen.Backend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Text.Json;

namespace Riksbyggen.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractsWebhookController(AppDbContext context) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Apartment>>> SetContractEndDate([FromBody] ContractsWebhookUpdateEndDateRequest request)
        {
            var apiKey = Request.Headers["API-KEY"].FirstOrDefault();
            if (apiKey != "DemoKey")
                return Unauthorized();
            
            try {
                if (!DateTime.TryParse(request.ContractEndDate, out DateTime requestEndDate))
                    return BadRequest("Invalid date format");

                var contractId = request.Id;
                var contract = await context.Contracts.FirstOrDefaultAsync(c => c.Id == contractId);

                if (contract == null)
                    return NotFound($"Contract with ID {contractId} not found");
                if (requestEndDate <= contract.StartDate)
                    return BadRequest("End date must be after the start date");

                contract.EndDate = requestEndDate;
                await context.SaveChangesAsync();

                return Ok();
            }
            catch(Exception ex) {
                //Log exception
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        public class ContractsWebhookUpdateEndDateRequest
        {
            public required int Id { get; set; }
            public required string ContractEndDate { get; set; }
        }

    }


}
