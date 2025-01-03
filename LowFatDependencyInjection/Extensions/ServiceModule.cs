using Autofac;
using LowFatDependencyInjection.Services;

namespace LowFatDependencyInjection.Extensions
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<ShoppingCartService>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
