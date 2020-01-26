using BlazorNorthwindUI.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Add(ProductViewModel productViewModel)
        {
            await _httpClient.PostJsonAsync("https://localhost:44388/api/products/add", productViewModel);
        }

        public Task<ProductViewModel> GetProductById(int productId)
        {
            return _httpClient.GetJsonAsync<ProductViewModel>("https://localhost:44388/api/products/getbyid?productid=" + productId);
        }

        public Task<Product[]> GetProducts()
        {
            return _httpClient.GetJsonAsync<Product[]>("https://localhost:44388/api/products/getall");
        }

        public async Task Save(ProductViewModel productViewModel)
        {
            await _httpClient.PostJsonAsync("https://localhost:44388/api/products/update", productViewModel);
        }
    }
}
