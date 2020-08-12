using RabbitMQ.Client;

namespace Audit
{
    class RabbitConn 
    {
        public static IConnection  GetChannel() 
        {
            var factory = new ConnectionFactory()
                {
                    HostName = "localhost",
                    Port = 5672,
                    UserName = "guest",
                    Password = "guest"
                };
            
            return factory.CreateConnection();
           
            
        }

    }

}
