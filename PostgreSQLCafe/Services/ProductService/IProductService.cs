using PostgreSQLCafe.Dto.ProductDto;

namespace PostgreSQLCafe.Services.ProductService
{
    public interface IProductService
    {
        public Task<List<ResultProductDto>> GetProductsStatusTrueAsync();
        public Task<Dictionary<int, List<ResultProductWithCategoryDto>>> GetProductsWithCategoryAsync();
    }
}
