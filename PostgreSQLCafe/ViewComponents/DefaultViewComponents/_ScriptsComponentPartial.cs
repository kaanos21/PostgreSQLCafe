using Microsoft.AspNetCore.Mvc;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _ScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
