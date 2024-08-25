using Microsoft.AspNetCore.Mvc;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _HeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
