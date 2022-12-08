using System;
using System.Collections.Generic;
using Testing.Models;
using System.Data;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);  
    }
}
