using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ProjectEuler.Web.Controllers
{
    [Controller]
    [Route("/api/sample")]
    public class ApiSampleController : BaseController
    {
        public ApiSampleController(ILogger<ApiSampleController> logger)
            : base(logger)
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new
            {
                utc = DateTimeOffset.UtcNow,
                local = DateTimeOffset.Now,
            });
        }
    }
}
