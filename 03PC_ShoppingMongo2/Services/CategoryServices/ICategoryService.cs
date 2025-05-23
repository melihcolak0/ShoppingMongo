using _03PC_ShoppingMongo2.DTOs.CategoryDTOs;

namespace _03PC_ShoppingMongo2.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetCategoryDto> GetCategoryByIdAsync(string id);
    }
}
