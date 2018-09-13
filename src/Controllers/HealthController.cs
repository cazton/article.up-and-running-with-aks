using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiApp.Controllers
{
    /// <summary>
    /// Example application health endpoint
    /// </summary>
    [Route("")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("health")]
        public ActionResult<string> Get()
        {
            return "OK";
        }
    }
}
