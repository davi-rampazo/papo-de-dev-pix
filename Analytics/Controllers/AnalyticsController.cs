using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Analytics.Controllers
{
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Analytics";
        }

        [Route("/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }
    }
}
