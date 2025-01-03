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
    }
}
