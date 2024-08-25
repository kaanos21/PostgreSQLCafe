using Microsoft.AspNetCore.Mvc;
using PostgreSQLCafe.Services.ProductService;

namespace PostgreSQLCafe.ViewComponents.DefaultViewComponents
{
    public class _MenuAreaComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _MenuAreaComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vv = await _productService.GetProductsWithCategoryAsync();
            return View(vv);
        }
    }
}
