using GeekShop.Web.Services;
using GeekShop.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShop.Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var access_token = await HttpContext.GetTokenAsync("access_token");
            var products = await productService.FindAllProducts(access_token);

            return View(products);
        }

        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            var access_token = await HttpContext.GetTokenAsync("access_token");
            var model = await productService.FindProductById(id, access_token);
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Login()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}
