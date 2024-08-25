using Microsoft.AspNetCore.Mvc;
using PostgreSQLCafe.Services.SliderService;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _BannerAreaComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;
        public _BannerAreaComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values= await _sliderService.GetSliderListAsync();
            return View(values);
        }
    }
}
