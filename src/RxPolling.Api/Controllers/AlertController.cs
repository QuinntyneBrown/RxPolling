using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace RxPolling.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertsController
    {
        public AlertsController()
        {

        }

        [HttpGet]
        public async Task<ActionResult> Get(DateTime timestamp)
        {
            return new OkObjectResult(null);
        }
    }
}
