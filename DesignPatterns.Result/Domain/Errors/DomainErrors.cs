using DesignPatterns.Result.Domain.EstatusYTipos;
using DesignPatterns.Result.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Result.Domain.Errors
{
    internal static class DomainErrors
    {
        // Generic Errors
        public static Error NotFound(Guid id, string entityName) => new Error(ErrorType.NotFound, $"{entityName} with id {id} was not found");
        public static Error NullValue(string fieldName) => new Error(ErrorType.NullValue, $"{fieldName} cannot be null");
        // Concrete Errors
        public static class Cart
        {
            public static Error ProductNotFound(Guid id) => new Error(ErrorType.NotFound, $"Product with id {id} was not found in the cart");
            public static Error ProductOutOfStock(Guid id) => new Error(ErrorType.InvalidOperation, $"Product with id {id} is out of stock");
        }
    }
}
