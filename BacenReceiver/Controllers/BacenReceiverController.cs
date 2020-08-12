using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using BacenReceiver;

namespace BacenReceiver.Controllers
{
    [ApiController]
    public class BacenReceiverController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Serviço Bacen Receiver";
        }

        [Route("/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }

        [Route("/message")]
        [HttpGet]
        public ActionResult<string> GetMessage()
        {
            return Producer.send(BacenConn.GetMessage());            
        }
    }
}
