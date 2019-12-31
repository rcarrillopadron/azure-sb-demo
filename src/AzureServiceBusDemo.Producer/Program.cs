using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.EventHubs;
using Microsoft.Extensions.Configuration;

namespace AzureServiceBusDemo.Producer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            var configurationRoot = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string EventHubConnectionString = configurationRoot["EventHubConnectionString"];
            string EventHubName = configurationRoot["EventHubName"];
            var connectionStringBuilder = new EventHubsConnectionStringBuilder(EventHubConnectionString)
            {
                EntityPath = EventHubName
            };

            EventHubClient eventHubClient = EventHubClient.CreateFromConnectionString(connectionStringBuilder.ToString());

            int numMessagesToSend = 100;
            for (var i = 0; i < numMessagesToSend; i++)
            {
                try
                {
                    var message = $"Message {i}";
                    Console.WriteLine($"Sending message: {message}");
                    await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(message)));
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"{DateTime.Now} > Exception: {exception.Message}");
                }
            }

            Console.WriteLine($"{numMessagesToSend} messages sent.");

            await eventHubClient.CloseAsync();
        }
    }
}
