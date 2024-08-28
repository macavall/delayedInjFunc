using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp3
{
    public class DelayedServiceExecutor : IHostedService
    {
        private readonly IMyService _myService;

        public DelayedServiceExecutor(IMyService myService)
        {
            _myService = myService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(10000); // Delay for 10 seconds

            // Now you can use the service after the delay
            _myService.Execute();
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }

    // Extension method and example services
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<IMyService, MyService>();
            services.AddTransient<IOtherService, OtherService>();
            return services;
        }
    }

    public interface IMyService
    {
        void Execute();
    }

    public class MyService : IMyService
    {
        public void Execute()
        {
            // Implementation here
            Console.WriteLine("MyService executed after delay.");
        }
    }

    public interface IOtherService
    {
        void Perform();
    }

    public class OtherService : IOtherService
    {
        public void Perform()
        {
            // Implementation here
        }
    }
}