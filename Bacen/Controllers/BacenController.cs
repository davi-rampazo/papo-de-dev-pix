using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bacen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BacenController : ControllerBase
    {
        // GET api/values
        // Para aceitar o certificado self-signed: dotnet dev-certs https -t -v
        [HttpGet]
        public ActionResult<string> Get()
        {
            StreamReader streamReader = new StreamReader("pacs.008_CONTA_1_msg.xml");
            return streamReader.ReadToEnd();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] XmlDocument value)
        {
            //Alteração feita no Startup.cs para aceitar XML
            Console.WriteLine(value.DocumentElement.OuterXml);
        }
    }
}
