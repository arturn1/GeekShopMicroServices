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
using System.Globalization;
using System.Linq;
using System.Security.Claims;
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

        public async Task<IActionResult> ProductIndex()
        {
            #region checks
            var access_token = await HttpContext.GetTokenAsync("access_token");
            var id_token = await HttpContext.GetTokenAsync("id_token");
            var token_type = await HttpContext.GetTokenAsync("token_type");
            var tok =  HttpContext.GetRouteData();
            var toke = HttpContext.GetEndpoint();
            var type = HttpContext.GetType();
            var typ = HttpContext.Request.Headers["Referer"].ToString();

            var c = User.IsInRole("Client");
            var a = User.IsInRole("Admin");

            var userEmail = User.Claims.FirstOrDefault(x => x.Type == "email")?.Value;
            var userRoles = User.Claims.FirstOrDefault(x => x.Type == "role")?.Value;
            var userName = User.Claims.FirstOrDefault(x => x.Type == "name")?.Value;
            var userTime = Convert.ToDouble(User.Claims.FirstOrDefault(x => x.Type == "auth_time")?.Value);

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(userTime).ToLocalTime();
            #endregion

            EnviarEmail();
            var products = await _productService.FindAllProducts("");
            var name = products.FirstOrDefault().Name;
            AcabarEspera(name);
            return View(products);
        }

        [Authorize(Roles = "Admin, Client")]
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
                var token = await HttpContext.GetTokenAsync("access_token");
                var response = await _productService.CreateProduct(model, token);
                if (response != null) return RedirectToAction(
                     nameof(ProductIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProductUpdate(Guid id)
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            var model = await _productService.FindProductById(id, token);
            if (model != null) return View(model);
            return NotFound();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var token = await HttpContext.GetTokenAsync("access_token");
                var response = await _productService.UpdateProduct(model, token);
                if (response != null) return RedirectToAction(
                     nameof(ProductIndex));
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> ProductDelete(Guid id)
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            var model = await _productService.FindProductById(id, token);
            if (model != null) return View(model);
            return NotFound();
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> ProductDelete(ProductViewModel model)
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            var response = await _productService.DeleteProductById(model.Id, token);
            if (response) return RedirectToAction(
                    nameof(ProductIndex));
            return View(model);
        }

        public async Task Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
        }

        private async void EnviarEmail()
        {
            await Task.Run(() => Task.Delay(5000));
            Console.WriteLine("Acabei a tarefa e enviei o e-mails");
        }

        private async Task AcabarEspera(string productName)
        {
            await Task.Delay(7000);
            Console.WriteLine(productName);
        }

        private async void RunInBackground(Action action)
        {
            await Task.Run(action);
        }
    }
}