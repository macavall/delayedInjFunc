//using Microsoft.Extensions.DependencyInjection;

//namespace FunctionApp3
//{
//    public static class ServiceCollectionExtensions2
//    {
//        public static IServiceCollection AddMyServices(this IServiceCollection services)
//        {
//            // Register your services here, for example:
//            services.AddSingleton<IMyService, MyService>();
//            services.AddTransient<IOtherService, OtherService>();

//            // Add other necessary services
//            // services.AddScoped<...>();

//            return services;
//        }
//    }

//    // Example services
//    public interface IMyService
//    {
//        void Execute();
//    }

//    public class MyService : IMyService
//    {
//        public void Execute()
//        {
//            // Implementation here

//            FunctionApp32.FunctionApp32.FuncMethod();
//        }
//    }

//    public interface IOtherService
//    {
//        void Perform();
//    }

//    public class OtherService : IOtherService
//    {
//        public void Perform()
//        {
//            // Implementation here
//        }
//    }
//}
