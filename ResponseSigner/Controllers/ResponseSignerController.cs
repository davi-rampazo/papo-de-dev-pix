using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CreditResponse.Controllers
{
    [ApiController]
    public class ResponseSignerController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Response Signer";
        }

        [Route("[controller]/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }
    }
}
