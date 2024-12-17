using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dependency_injection.DataAccess;
using dependency_injection.Entities;

namespace dependency_injection.Business
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }
    }
}