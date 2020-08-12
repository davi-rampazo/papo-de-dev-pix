using System;
using System.Text;
//dotnet add package RabbitMQ.Client --version 6.1.0
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Threading;

namespace Credit
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
                Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")} - Mensagem Recebida - pix_validated");

                // Transformando antes de enviar
                var body = Encoding.UTF8.GetBytes(message);
                string routing = "pix_route_notauth";
                
                // Se a transacao for valida, vai para efetivação do credito, senão vai para a fila inválida
                if (CreditAgent.process(message)) 
                {
                    routing = "pix_route_credited";

                    channel.BasicPublish(exchange: "pix",
                                        routingKey: "pix_route_account",
                                        basicProperties: null,
                                        body: body);
                }

                channel.BasicPublish(exchange: "pix",
                                        routingKey: routing,
                                        basicProperties: null,
                                        body: body);

                Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")} - Mensagem Enviada - " + routing);                

                channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };

            channel.BasicConsume(queue: "pix_validated",autoAck: false,consumer: consumer);
            Console.WriteLine("Channel state:" + channel.IsOpen);
        }

    }

}