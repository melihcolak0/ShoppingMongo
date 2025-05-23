using Microsoft.AspNetCore.Mvc;

namespace _03PC_ShoppingMongo2.ViewComponents.Admin
{
    public class _HeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
