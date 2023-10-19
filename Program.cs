
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace BloblPractice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Securely set up our connection string
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
            var getConnectionString = config["connectionString"];
        }
    }
}