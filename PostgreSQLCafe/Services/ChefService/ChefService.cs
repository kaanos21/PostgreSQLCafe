using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Context;
using PostgreSQLCafe.Dto.ChefDto;

namespace PostgreSQLCafe.Services.ChefService
{
    public class ChefService : IChefService
    {
        private readonly CafeContext _context;
        public ChefService(CafeContext context)
        {
            _context = context;
        }
        public async Task<List<ResultChefWithSocialMediaDto>> GetChefWithSocialMediaAsync()
        {
            var chefs = await _context.Chefs
                .Include(c => c.SocialMedias)
                .ToListAsync();

            return chefs.Select(c => new ResultChefWithSocialMediaDto
            {
                Id = c.Id,
                Name = c.Name,
                Role = c.Role,
                SocialMediaLinks = c.SocialMedias.Select(s => s.SocialMediaUrl).ToList()
            }).ToList();
        }
    }
}
