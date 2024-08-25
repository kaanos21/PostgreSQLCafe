using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Context;
using PostgreSQLCafe.Dto.CategoryDto;

namespace PostgreSQLCafe.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly CafeContext _context;
        public CategoryService(CafeContext context)
        {
            _context = context;
        }
        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var value = await _context.Categories.ToListAsync();
            var result = value.Select(s => new ResultCategoryDto
            {
                Id = s.Id,
                Name = s.Name,
            }).ToList();
            return result;
        }
    }
}
