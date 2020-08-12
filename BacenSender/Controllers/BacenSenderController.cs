using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BacenSender.Controllers
{
    [ApiController]
    public class BacenSenderController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Bacen Sender";
        }

        [Route("/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }
    }
}
