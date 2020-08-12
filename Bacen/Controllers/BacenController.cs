/**
* Autor: davi.rampazo@avanade.com / @gmail.com
* Este controller simplesmente carrega a mensagem pacs008 do arquivo e enviar como resposta no método Get
* No Post ele recebe a pacs002 e escreve no Console
* Em certas situações pode-se receber um erro no momento da chamada do serviço por conta do certificado
*   self-signed não estar configurado, utilize o comando na home do projeto: 
    dotnet dev-certs https -t -v
* Originalmente o webapi é otimizado para serializar mensagens em Json, aqui tive que fazer uma cus-
*   tomização para habilitar o processamento de XML, dentro da configuração do serviço no Startup.cs:
*       services.AddMvc(config =>
        {
            config.RespectBrowserAcceptHeader = true;
            #pragma warning disable 0618
            config.InputFormatters.Add(new XmlSerializerInputFormatter());
            config.OutputFormatters.Add(new XmlSerializerOutputFormatter());
        });

*/
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
        [HttpGet]
        public ActionResult<string> Get()
        {
            StreamReader streamReader = new StreamReader("pacs.008_CONTA_1_msg.xml");
            return streamReader.ReadToEnd();
        }

        [HttpPost]
        public void Post([FromBody] XmlDocument value)
        {
            //Alteração feita no Startup.cs para aceitar XML
            Console.WriteLine(value.DocumentElement.OuterXml);
        }
    }
}
