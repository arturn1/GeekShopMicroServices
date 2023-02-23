using GeekShop.React.Models;
using GeekShop.React.Services.IServices;
using System.Net.Http.Headers;

namespace GeekShop.React.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "https://localhost:4440/api/v1/product";

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ProductViewModel>> FindAllProducts(string token)
        {
            var response = await _client.GetFromJsonAsync<List<ProductViewModel>>(BasePath);
            return response ?? new List<ProductViewModel>();
        }

        public async Task<ProductViewModel> FindProductById(Guid id, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.GetFromJsonAsync<ProductViewModel>($"{BasePath}/{id}");
            return response ?? new ProductViewModel();
        }

        public async Task<ProductViewModel> CreateProduct(ProductViewModel model, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PostAsJsonAsync(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<ProductViewModel>();
            else throw new Exception("Something went wrong when calling API");
        }
        public async Task<ProductViewModel> UpdateProduct(ProductViewModel model, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PostAsJsonAsync(BasePath, model);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<ProductViewModel>();
            else throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> DeleteProductById(Guid id, string token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<bool>();
            else throw new Exception("Something went wrong when calling API");
        }
    }
}
