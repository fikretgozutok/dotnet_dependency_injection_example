using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dependency_injection.Entities;

namespace dependency_injection.DataAccess
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>
            {
                new Product(1, "Laptop", 15000),
                new Product(2, "Mouse", 300),
                new Product(3, "Keyboard", 700)
            };
        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }
    }


    public class EfProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>
            {
                new Product(1, "elma", 15000),
                new Product(2, "armut", 300),
                new Product(3, "muz", 700)
            };
        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }
    }
}