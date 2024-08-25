using PostgreSQLCafe.Dto.CategoryDto;

namespace PostgreSQLCafe.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
    }
}
