
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Config
{
    public static class ConnectionConfig
    {
        private static IConfigurationRoot? configuration;

        public static string GetConnectionString()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            return configuration.GetConnectionString("DefaultConnection")
                    ?? throw new InvalidOperationException("Connection string not found.");
        }
    }
}


