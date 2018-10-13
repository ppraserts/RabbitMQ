using System;
using RabbitMQ.Client;
using System.Text;

namespace Send
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using(var connection = factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

                bool continueQueue = true;
                Console.WriteLine("What is your message? if you want to exit press (q)");
                do{
                    string message = Console.ReadLine().ToString();
                    if(message.Equals("q")){
                        continueQueue = false;
                        message = "Bye!!!";
                    }

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                        routingKey: "hello",
                                        basicProperties: null,
                                        body: body);
                    Console.WriteLine(" [x] Sent {0}", message);

                } while(continueQueue);
            }

            //Console.WriteLine(" Press [enter] to exit.");
            //Console.ReadLine();
        }
    }
}
