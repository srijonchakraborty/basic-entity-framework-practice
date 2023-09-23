using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFrameWorkBasicPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost("checkHome")]
        public async Task<ActionResult<dynamic>> CheckHome([FromBody] dynamic checkHomeRequest)
        {
            if (ModelState.IsValid)
            {
                return Ok("Done");
            }
            return BadRequest(ModelState);
        }
    }
}