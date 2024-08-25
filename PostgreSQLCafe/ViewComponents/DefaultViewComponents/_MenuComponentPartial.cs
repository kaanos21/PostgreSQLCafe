using Microsoft.AspNetCore.Mvc;
using PostgreSQLCafe.Services.ProductService;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _MenuComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;
        public _MenuComponentPartial(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
           var vv= await _productService.GetProductsStatusTrueAsync();
            return View(vv);
        }
    }
}
