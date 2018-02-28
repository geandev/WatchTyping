using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace WatchTyping.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/watchtyping")
                .Build();

            connection.On<string>("send", data =>
            {
                Console.WriteLine($"Received: {data}");
            });

            connection.StartAsync().Wait();

            Console.Read();
        }
    }
}
