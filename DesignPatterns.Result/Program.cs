using DesignPatterns.Result.Domain;
using DesignPatterns.Result.Domain.Errors;
using DesignPatterns.Result.Domain.Shared;

namespace DesignPatterns.Result
{
    internal class Program
    {
        private static List<Product> storeProducts = new()
        {
            new("Product 1", 10, 1),
            new("Product 2", 20, 2),
            new("Product 3", 30, 3),
            new("Product 4", 40, 4),
            new("Product 5", 50, 5),
        };
        static void Main(string[] args)
        {
            var cart = new Cart();
            var productInCart = AddProductToCart(cart, storeProducts[0].Id);
            if (productInCart.IsFailure)
            {
                Console.WriteLine(productInCart.Error.Message);
            }
            var total = GetTotal(cart);
            var productNotInCart = RemoveProductFromCart(cart, storeProducts[1].Id);
            if (productNotInCart.IsFailure)
            {
                Console.WriteLine(productNotInCart.Error.Message);
            }
            total = GetTotal(cart);
            Console.WriteLine(total.Value);
        }
        public static Result<Product> AddProductToCart(Cart cart, Guid productId)
        {
            var product = storeProducts.FirstOrDefault(p => p.Id == productId);
            if (product == null) return Domain.Shared.Result.Failure<Product>(DomainErrors.NotFound(productId, "Product"));
            return cart.AddProduct(product);
        }
        public static Result<Product> RemoveProductFromCart(Cart cart, Guid productId)
        {
            var product = storeProducts.FirstOrDefault(p => p.Id == productId);
            if (product == null) return Domain.Shared.Result.Failure<Product>(DomainErrors.NotFound(productId, "Product"));
            return cart.RemoveProduct(product);
        }
        public static Result<decimal> GetTotal(Cart cart)
        {
            return cart.GetTotal();
        }
    }
}
