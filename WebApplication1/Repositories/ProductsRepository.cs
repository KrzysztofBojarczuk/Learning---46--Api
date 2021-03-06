using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Api;

namespace WebApplication1.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        public Product GetProduct(string id)
        {
            var idNumber = Convert.ToInt32(id);
            var products = GetProducts();

            return products.Where(p => p.Id == idNumber).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            return products;
        }
    }
}
