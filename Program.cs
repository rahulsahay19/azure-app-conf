using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace azure_app_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddAzureAppConfiguration(Environment.GetEnvironmentVariable("ConnectionString"));

            var config = builder.Build();
            Console.WriteLine(config["TestApp:Settings:Message"] ?? "Hello world!");
        }
    }
}
