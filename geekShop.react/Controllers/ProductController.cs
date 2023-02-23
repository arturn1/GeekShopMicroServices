using GeekShop.React.Models;
using GeekShop.React.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GeekShopping.React.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [HttpGet]
        [Route("/")]
        public async Task<IEnumerable<ProductViewModel>> Index()
        {
            var products = await _productService.FindAllProducts("");
            return products;
        }
    }
}