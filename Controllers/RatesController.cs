using LoanRatesApi.Models; // Import the models namespace
using LoanRatesApi.Services; // Import the services namespace
using Microsoft.AspNetCore.Mvc; // Import ASP.NET Core MVC namespace

namespace LoanRatesApi.Controllers // Define the namespace for controllers
{
    [ApiController] // Marks this class as an API controller
    [Route("api/[controller]")] // Route: api/rates
    public class RatesController : ControllerBase // Inherits from ControllerBase
    {
        private readonly IRateService _rateService; // Declare rate service dependency

        public RatesController(IRateService rateService) // Constructor injection of IRateService
        {
            _rateService = rateService; // Assign to private field
        }

        [HttpGet] // HTTP GET method
        public ActionResult<Rate> Get([FromQuery] string loanType, [FromQuery] int term) // Endpoint: /api/rates?loanType=X&term=Y
        {
            // Validate input parameters
            if (string.IsNullOrEmpty(loanType) || term <= 0)
                return BadRequest("Invalid loanType or term"); // Return 400 Bad Request if validation fails

            var rate = _rateService.GetRate(loanType, term); // Get rate from service
            return Ok(rate); // Return 200 OK with the rate data
        }
    }
}