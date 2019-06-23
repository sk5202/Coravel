using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coravel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoreWorkerServiceSchedularJob
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
            host.Services.UseScheduler(scheduler => {
              
                // Remind schedular to repeat same job in every five second 
                scheduler
                    .Schedule<MyFirstJob>()
                    .EveryFiveSeconds();


            });
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddScheduler();

                    // register job with container
                    services.AddTransient<MyFirstJob>();
                });
    };
}

