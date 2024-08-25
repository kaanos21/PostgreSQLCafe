
using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Context;

namespace PostgreSQLCafe.Dto.StatisticService
{
    public class StatisticService : IStatisticService
    {
        private readonly CafeContext _context;
        public StatisticService(CafeContext context)
        {
            _context = context;
        }
        public async Task<int> CategoryCount()
        {
            var value=await _context.Categories.CountAsync();
            return value;
        }
        public async Task<int> ChefCount()
        {
            var value = await _context.Chefs.CountAsync();
            return value;
        }
        public async Task<int> ProductCount()
        {
            var value = await _context.Products.CountAsync();
            return value;
        }
        public async Task<int> RezervationCount()
        {
            var value = await _context.Reservations.CountAsync();
            return value;
        }
    }
}
