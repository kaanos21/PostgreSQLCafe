using Microsoft.AspNetCore.Mvc;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _AboutAreaComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
