using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FunctionApp3
{

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var host = new HostBuilder()
            .ConfigureFunctionsWebApplication()
            .ConfigureServices(services =>
            {
                services.AddApplicationInsightsTelemetryWorkerService();
                services.ConfigureFunctionsApplicationInsights();
            })
            .Build();

            await host.RunAsync();

            //var host = new HostBuilder()
            //.ConfigureFunctionsWebApplication()
            //.ConfigureServices(services =>
            //{
            //    services.AddApplicationInsightsTelemetryWorkerService();
            //    services.ConfigureFunctionsApplicationInsights();

            //    try
            //    {
            //        services.AddHostedService<DelayedServiceExecutor>();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("==============================");
            //        Console.WriteLine("\n" + ex.Message + "\n");
            //        Console.WriteLine("\n" + ex.InnerException + "\n");
            //        Console.WriteLine("==============================");
            //    }

            //    // services.AddMyServices();
            //})
            //.Build();

            //try
            //{
            //    await host.RunAsync();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("==============================");
            //    Console.WriteLine("\n" + ex.Message + "\n");
            //    Console.WriteLine("\n" + ex.InnerException + "\n");
            //    Console.WriteLine("==============================");
            //}

        }
    }
}