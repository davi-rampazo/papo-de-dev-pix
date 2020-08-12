using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Audit.Controllers
{
    [ApiController]
    public class AuditController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Audit";
        }

        [Route("/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }
    }
}
