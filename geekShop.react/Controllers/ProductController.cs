using GeekShop.React.Models;
using GeekShop.React.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GeekShopping.React.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }


        [HttpGet]
        [Route("product")]
        public async Task<IEnumerable<ProductViewModel>> Index()
        {
            var products = await _productService.FindAllProducts("");
            return products;
        }
    }
}