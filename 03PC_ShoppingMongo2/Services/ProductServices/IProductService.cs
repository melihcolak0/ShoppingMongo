﻿using _03PC_ShoppingMongo2.DTOs.ProductDTOs;

namespace _03PC_ShoppingMongo2.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetProductDto> GetProductByIdAsync(string id);
    }
}
