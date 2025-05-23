using _03PC_ShoppingMongo2.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace _03PC_ShoppingMongo2.ViewComponents.UI
{
    public class _UIProductDetailComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public _UIProductDetailComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return View(product);
        }
    }
}
