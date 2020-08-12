using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Account.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Account";
        }

        [Route("/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }

        [Route("/balance")]
        [HttpGet]
        public ActionResult<string> GetBalance()
        {
            return "Get Balance";
        }        
    }
}
