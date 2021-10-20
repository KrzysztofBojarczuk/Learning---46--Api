using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Api;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public Product GetProduct(string id)
        {
            return _productsRepository.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _productsRepository.GetProducts();
        }
    }
}
