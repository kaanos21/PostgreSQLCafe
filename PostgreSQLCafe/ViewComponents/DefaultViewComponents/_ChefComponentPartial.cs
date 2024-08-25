using Microsoft.AspNetCore.Mvc;
using PostgreSQLCafe.Services.ChefService;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _ChefComponentPartial : ViewComponent
    {
        private readonly IChefService _chefService;
        public _ChefComponentPartial(IChefService chefService)
        {
            _chefService = chefService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vv=await _chefService.GetChefWithSocialMediaAsync();
            return View(vv);
        }
    }
}
