namespace LowFatDependencyInjection.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IList<Product> Products { get; set; }
    }
}
