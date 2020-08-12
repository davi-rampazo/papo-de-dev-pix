using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace HSM.Controllers
{
    [ApiController]
    public class HSMController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public string Get()
        {
            return "Serviço HSM";
        }

        [Route("[controller]/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }

        [Route("[controller]/unsign")]
        [HttpPost]
        public string PostUnsign([FromBody] System.Xml.XmlDocument xmlDoc)
        {
            //Vamos dar um tempinho para simular um processamento
            Thread.Sleep(80);
            return xmlDoc.OuterXml;
        }   
        [Route("[controller]/sign")]
        [HttpPost]
        public string PostSign([FromBody] System.Xml.XmlDocument xmlDoc)
        {
            //Vamos dar um tempinho para simular um processamento
            Thread.Sleep(80);
            return xmlDoc.OuterXml;
        }             
    }
}
