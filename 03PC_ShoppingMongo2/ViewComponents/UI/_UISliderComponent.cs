using _03PC_ShoppingMongo2.Services.SliderServices;
using Microsoft.AspNetCore.Mvc;

namespace _03PC_ShoppingMongo2.ViewComponents.UI
{
    public class _UISliderComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _UISliderComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }
    }
}
