using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Validation.Controllers
{
    [ApiController]
    public class ValidatorController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Formatter";
        }

        [Route("[controller]/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }
    }
}
