using _03PC_ShoppingMongo2.DTOs.ProductImageDTOs;
using _03PC_ShoppingMongo2.Services.ProductImageServices;
using _03PC_ShoppingMongo2.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _03PC_ShoppingMongo2.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;
        private readonly IProductService _productService;

        public ProductImageController(IProductImageService productImageService, IProductService productService)
        {
            _productImageService = productImageService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productImageService.GetAllProductImageAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProductImage()
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(c => new SelectListItem
            {
                Text = c.ProductName,
                Value = c.ProductId
            }).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProductImage(string id)
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(c => new SelectListItem
            {
                Text = c.ProductName,
                Value = c.ProductId
            }).ToList();

            var ProductImage = await _productImageService.GetProductImageByIdAsync(id);
            return View(ProductImage);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return RedirectToAction("Index");
        }
    }
}
