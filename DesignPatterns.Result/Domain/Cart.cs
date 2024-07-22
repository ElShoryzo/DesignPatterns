using DesignPatterns.Result.Domain.Errors;
using DesignPatterns.Result.Domain.EstatusYTipos;
using DesignPatterns.Result.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Result.Domain
{
    internal class Cart
    {
        private List<Product> _products { get; set; }
        public IReadOnlyList<Product> Products => _products.AsReadOnly();
        public Cart()
        {
            _products = new();
        }
        public Result<Product> AddProduct(Product product)
        {
            if (product.Stock == 0) return Shared.Result.Failure<Product>(DomainErrors.Cart.ProductOutOfStock(product.Id));
            _products.Add(product);
            return product;
        }
        public Result<Product> RemoveProduct(Product product)
        {
            if(!_products.Contains(product)) return Shared.Result.Failure<Product>(DomainErrors.Cart.ProductNotFound(product.Id));
            _products.Remove(product);
            return product;
        }
        public decimal GetTotal()
        {
            return _products.Sum(p => p.Price);
        }
    }
}
