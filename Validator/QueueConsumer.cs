using System;
using System.Text;
//dotnet add package RabbitMQ.Client --version 6.1.0
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Threading;

namespace Validation
{
    public class QueueConsumer
    {
        public static void Start()
        {
            var connection = RabbitConn.GetChannel();
            var channel = connection.CreateModel();
            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (model, ea) =>
            {
                var message = Encoding.UTF8.GetString(ea.Body.Span);
                Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")} - Mensagem Recebida - pix_formatted");

                // Transformando antes de enviar
                var body = Encoding.UTF8.GetBytes(message);             
                string routing = "pix_route_invalid";
                
                // Se a transacao for valida, vai para efetivação do credito, senão vai para a fila inválida
                if (ValidatorAgent.process(message)) 
                {
                    routing = "pix_route_validated";
                }

                channel.BasicPublish(exchange: "pix",
                                        routingKey: routing,
                                        basicProperties: null,
                                        body: body);

                channel.BasicPublish(exchange: "pix",
                                        routingKey: "pix_route_engagement",
                                        basicProperties: null,
                                        body: body);                                        

                Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")} - Mensagem Enviada - " + routing);                

                channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };

            channel.BasicConsume(queue: "pix_formatted",autoAck: false,consumer: consumer);
            Console.WriteLine("Channel state:" + channel.IsOpen);
        }

    }

}