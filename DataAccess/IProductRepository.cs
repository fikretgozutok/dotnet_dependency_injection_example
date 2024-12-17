using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dependency_injection.Entities;

namespace dependency_injection.DataAccess
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}