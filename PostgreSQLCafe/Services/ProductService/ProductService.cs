using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Context;
using PostgreSQLCafe.Dto.ProductDto;

namespace PostgreSQLCafe.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly CafeContext _context;
        public ProductService(CafeContext context)
        {
            _context = context;
        }
        public async Task<List<ResultProductDto>> GetProductsStatusTrueAsync()
        {
            var value= await _context.Products.Where(x=>x.Status==true).ToListAsync();
            var result = value.Select(s => new ResultProductDto
            {
                Price = s.Price,
                CategoryId = s.CategoryId,
                Description = s.Description,
                Id = s.Id,
                ImageUrl = s.ImageUrl,
                Name = s.Name,
                Status = s.Status,
            }).ToList();
            return result;
        }

        public async Task<Dictionary<int, List<ResultProductWithCategoryDto>>> GetProductsWithCategoryAsync()
        {
            var value = await _context.Products
                .Where(p => p.CategoryId.HasValue) // Null olmayan değerleri filtrele
                .ToListAsync();

            var result = value
                .GroupBy(s => s.CategoryId.Value) // Nullable olmayan değeri kullan
                .ToDictionary(g => g.Key, g => g.Select(s => new ResultProductWithCategoryDto
                {
                    Price = s.Price,
                    CategoryId = s.CategoryId.Value, // Nullable olmayan değeri kullan
                    Description = s.Description,
                    Id = s.Id,
                    ImageUrl = s.ImageUrl,
                    Name = s.Name,
                    Status = s.Status,
                }).ToList());

            return result;
        }


    }
}
