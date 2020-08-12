using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Formatter.Controllers
{
    [ApiController]
    public class FormatterController : ControllerBase
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
