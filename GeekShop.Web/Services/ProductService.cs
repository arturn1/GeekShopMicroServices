using GeekShop.Web.Models;
using GeekShop.Web.Services.IServices;
//using GeekShopping.Web.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace GeekShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/product";

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ProductViewModel>> FindAllProducts()
        {
            //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = _client.GetAsync(BasePath).Result;
            var r =  response.Content.ReadAsStringAsync().Result;
            List<ProductViewModel> p = JsonSerializer.Deserialize<List<ProductViewModel>>(r);
            return p;
        }

        //public async Task<ProductViewModel> FindProductById(long id, string token)
        //{
        //    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //    var response = await _client.GetAsync($"{BasePath}/{id}");
        //    return await response.ReadContentAs<ProductViewModel>();
        //}

        //public async Task<ProductViewModel> CreateProduct(ProductViewModel model, string token)
        //{
        //    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //    var response = await _client.PostAsJson(BasePath, model);
        //    if (response.IsSuccessStatusCode)
        //        return await response.ReadContentAs<ProductViewModel>();
        //    else throw new Exception("Something went wrong when calling API");
        //}
        //public async Task<ProductViewModel> UpdateProduct(ProductViewModel model, string token)
        //{
        //    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //    var response = await _client.PutAsJson(BasePath, model);
        //    if (response.IsSuccessStatusCode)
        //        return await response.ReadContentAs<ProductViewModel>();
        //    else throw new Exception("Something went wrong when calling API");
        //}

        //public async Task<bool> DeleteProductById(long id, string token)
        //{
        //    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //    var response = await _client.DeleteAsync($"{BasePath}/{id}");
        //    if (response.IsSuccessStatusCode)
        //        return await response.ReadContentAs<bool>();
        //    else throw new Exception("Something went wrong when calling API");
        //}
    }
}
