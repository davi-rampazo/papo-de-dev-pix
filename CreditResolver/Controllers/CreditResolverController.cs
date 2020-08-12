using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Credit.Controllers
{
    [ApiController]
    public class CreditResolverController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Credit Resolver";
        }

        [Route("[controller]/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }
    }
}
