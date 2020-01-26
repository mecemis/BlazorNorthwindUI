using BlazorNorthwindUI.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public class CategoryService : ICategoryService
    {
        private HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Category[]> GetCategories()
        {
            return _httpClient.GetJsonAsync<Category[]>("https://localhost:44388/api/categories/getall");
        }
    }
}
