using Microsoft.AspNetCore.Hosting;
using ApplicatonDbContext.Data;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;


namespace ApplicatonDbContext
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
