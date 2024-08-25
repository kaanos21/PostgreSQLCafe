using Microsoft.AspNetCore.Mvc;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _PreloaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
