using _03PC_ShoppingMongo2.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace _03PC_ShoppingMongo2.ViewComponents.UI
{
    public class _UIProductComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public _UIProductComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);
        }
    }
}
