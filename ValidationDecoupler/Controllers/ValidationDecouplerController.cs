using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Pacs008;
using Model.Head;
using Model.Doc;

namespace ValidationDecoupler.Controllers
{
    [ApiController]
    public class ValidationDecouplerController : ControllerBase
    {
        [Route("[controller]")]
        [HttpGet]
        public string Get()
        {
            return "Serviço Validation Decoupler";
        }

        [Route("[controller]/health")]
        [HttpGet]
        public ActionResult<string> Health()
        {
            return "{\"Service\": \"UP\"}";
        }        

        [Route("[controller]/validate")]
        [HttpPost]
        public string Post([FromBody] Pacs008 pacs008)
        {

            return "{\"Message Id\": \"" + pacs008.Document.FIToFICstmrCdtTrf.GrpHdr.MsgId + 
                "\", \"status\": \"Validated\"}" ;

        }
    }
}
