using GeekShop.Web.Models;
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
        private readonly ICartService cartService;


        public HomeController(IProductService productService, ICartService cartService)
        {
            this.productService = productService;
            this.cartService = cartService;
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

        [HttpPost]
        [ActionName("Details")]
        [Authorize]
        public async Task<IActionResult> DetailsPost(ProductViewModel model)
        {
            var token = await HttpContext.GetTokenAsync("access_token");

            CartViewModel cart = new()
            {
                CartHeader = new CartHeaderViewModel
                {
                    UserId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value
                }
            };

            CartDetailViewModel cartDetail = new CartDetailViewModel()
            {
                Count = model.Count,
                ProductId = model.Id,
                Product = await productService.FindProductById(model.Id, token)
            };

            List<CartDetailViewModel> cartDetails = new List<CartDetailViewModel>();
            cartDetails.Add(cartDetail);
            cart.CartDetails = cartDetails;

            var response = await cartService.AddItemToCart(cart, token);
            if (response != null)
            {
                return RedirectToAction(nameof(Index));
            }
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
