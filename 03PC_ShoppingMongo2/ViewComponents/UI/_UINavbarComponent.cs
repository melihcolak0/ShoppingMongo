using Microsoft.AspNetCore.Mvc;

namespace _03PC_ShoppingMongo2.ViewComponents.UI
{
    public class _UINavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
