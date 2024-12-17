using dependency_injection.Business;
using dependency_injection.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            //.AddSingleton<IProductRepository, InMemoryProductRepository>()
            .AddSingleton<IProductRepository, EfProductRepository>()
            .AddSingleton<IProductService, ProductManager>()
            .BuildServiceProvider();

        var productService = serviceProvider.GetService<IProductService>();

        var productList = productService!.GetAllProducts();

        productList.ForEach(product => Console.WriteLine(product.Name));

    }
}
