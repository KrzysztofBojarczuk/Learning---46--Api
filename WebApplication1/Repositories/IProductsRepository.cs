using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Api;

namespace WebApplication1.Repositories
{
    public interface IProductsRepository
    {
        List<Product> GetProducts();
        Product GetProduct(string id);
    }
}
