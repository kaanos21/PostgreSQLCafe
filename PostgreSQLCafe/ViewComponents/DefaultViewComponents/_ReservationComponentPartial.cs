using Microsoft.AspNetCore.Mvc;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _ReservationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
