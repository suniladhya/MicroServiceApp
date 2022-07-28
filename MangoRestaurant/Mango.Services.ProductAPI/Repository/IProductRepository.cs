using System;
using Mango.Services.ProductAPI.Models;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreatUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}

