using Microsoft.AspNetCore.Mvc;

namespace Riksbyggen.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return Ok(new Company() { Id = 0});
        }
    }
}
