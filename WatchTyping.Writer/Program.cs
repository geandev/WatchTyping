using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace WatchTyping.Writer
{
    class Program
    {
        static void Main()
        {
            var connection = new HubConnectionBuilder()
                          .WithUrl("http://localhost:5000/watchtyping")
                          .Build();

            connection.StartAsync().Wait();

            while (true)
            {
                Console.WriteLine("Write a message");
                connection.InvokeAsync("SendAsync", Console.ReadLine()).Wait();
            }
        }
    }
}