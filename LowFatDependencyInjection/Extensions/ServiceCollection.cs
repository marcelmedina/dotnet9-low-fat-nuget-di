using Autofac.Extensions.DependencyInjection;
using Autofac;
using LowFatDependencyInjection.Services;

namespace LowFatDependencyInjection.Extensions
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddBuiltInServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();

            return services;
        }

        public static ConfigureHostBuilder AddAutofacServices(this ConfigureHostBuilder host)
        {
            host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
            {
                containerBuilder.RegisterModule<ServiceModule>();
            });

            return host;
        }
    }
}
