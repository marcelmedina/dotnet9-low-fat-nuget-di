using LowFatDependencyInjection.Models;

namespace LowFatDependencyInjection.Services
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        IList<Product> GetProducts();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }

    public class ProductService : IProductService
    {
        public void CreateProduct(Product product)
        {
            // TODO: Implement this method
        }

        public void DeleteProduct(int id)
        {
            // TODO: Implement this method
        }

        public Product GetProduct(int id)
        {
            return new Product();
        }

        public IList<Product> GetProducts()
        {
            return [];
        }

        public void UpdateProduct(Product product)
        {
            // TODO: Implement this method
        }
    }
}
