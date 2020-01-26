using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public interface IProductService
    {
        Task<Product[]> GetProducts();
        Task<ProductViewModel> GetProductById(int productId);
        Task Save(ProductViewModel productViewModel);
        Task Add(ProductViewModel productViewModel);
    }
}
