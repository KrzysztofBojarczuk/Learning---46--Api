using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _productsService.GetProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProduct(string id)
        {
            var product = _productsService.GetProduct(id);
            return Ok(product);
        }
    }
}
