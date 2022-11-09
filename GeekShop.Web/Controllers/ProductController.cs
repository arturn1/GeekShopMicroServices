using GeekShop.Web.Models;
using GeekShop.Web.Services.IServices;
using GeekShop.Web.Utils;
//using GeekShopping.Web.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [Authorize(Roles = "Client")]
        public async Task<IActionResult> ProductIndex()
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            var user = User;

            var products = await _productService.FindAllProducts(token);
            return View(products);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var token = await HttpContext.GetTokenAsync("access_token");
                var response = await _productService.CreateProduct(model/*, token*/);
                if (response != null) return RedirectToAction(
                     nameof(ProductIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProductUpdate(Guid id)
        {
            //var token = await HttpContext.GetTokenAsync("access_token");
            var model = await _productService.FindProductById(id/*, token*/);
            if (model != null) return View(model);
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var token = await HttpContext.GetTokenAsync("access_token");
                var response = await _productService.UpdateProduct(model/*, token*/);
                if (response != null) return RedirectToAction(
                     nameof(ProductIndex));
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> ProductDelete(Guid id)
        {
            //var token = await HttpContext.GetTokenAsync("access_token");
            var model = await _productService.FindProductById(id/*, token*/);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> ProductDelete(ProductViewModel model)
        {
            //var token = await HttpContext.GetTokenAsync("access_token");
            var response = await _productService.DeleteProductById(model.id/*, token*/);
            if (response) return RedirectToAction(
                    nameof(ProductIndex));
            return View(model);
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}