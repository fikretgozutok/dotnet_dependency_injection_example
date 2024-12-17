using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dependency_injection.Entities;

namespace dependency_injection.Business
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}