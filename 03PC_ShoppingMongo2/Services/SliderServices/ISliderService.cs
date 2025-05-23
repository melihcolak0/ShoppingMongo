using _03PC_ShoppingMongo2.DTOs.SliderDTOs;

namespace _03PC_ShoppingMongo2.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderAsync(string id);
        Task<GetSliderDto> GetSliderByIdAsync(string id);
    }
}
