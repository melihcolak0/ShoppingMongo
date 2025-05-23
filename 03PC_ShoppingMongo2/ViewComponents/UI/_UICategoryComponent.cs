using _03PC_ShoppingMongo2.Services.CategoryServices;
using _03PC_ShoppingMongo2.ViewComponents.UI;
using Microsoft.AspNetCore.Mvc;

namespace _03PC_ShoppingMongo2.ViewComponents.UI
{
    public class _UICategoryComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _UICategoryComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
    }
}