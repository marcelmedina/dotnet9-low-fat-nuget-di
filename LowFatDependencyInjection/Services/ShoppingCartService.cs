using LowFatDependencyInjection.Models;

namespace LowFatDependencyInjection.Services
{
    public interface IShoppingCartService
    {
        void UpsertShoppingCart(int userId, List<Product> products);
        void DeleteShoppingCart(int userId);
        ShoppingCart GetShoppingCart(int userId);
    }

    public class ShoppingCartService : IShoppingCartService
    {
        public void DeleteShoppingCart(int userId)
        {
            // TODO: Implement this method
        }

        public ShoppingCart GetShoppingCart(int userId)
        {
            return new ShoppingCart();
        }

        public void UpsertShoppingCart(int userId, List<Product> products)
        {
            // TODO: Implement this method
        }
    }
}
