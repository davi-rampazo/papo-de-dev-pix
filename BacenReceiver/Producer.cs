using System;
using System.Text;
//dotnet add package RabbitMQ.Client --version 6.1.0
using RabbitMQ.Client;

namespace BacenReceiver
{
    class Producer
    {
        public static string send(string xmlRecebido)
        {
            string returnMessage = $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")} - Mensagem Recebida - Bacen";
         
                using (var connection = RabbitConn.GetChannel())
                using (var channel = connection.CreateModel())
                {
                    
                    var body = Encoding.UTF8.GetBytes(xmlRecebido);

                    channel.BasicPublish(exchange: "pix",
                                         routingKey: "pix_route_received",
                                         basicProperties: null,
                                         body: body);

                    channel.BasicPublish(exchange: "pix",
                                         routingKey: "pix_route_audit",
                                         basicProperties: null,
                                         body: body);                                         
                }

            // #Preguiça - Sim, aqui tem que fechar a conexão!!!

            return returnMessage + 
                $"\n{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")} - Mensagem Enviada - pix_route_received";

        }
    }
}
