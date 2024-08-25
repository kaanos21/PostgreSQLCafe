using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Context;
using PostgreSQLCafe.Dto.SliderDto;
using PostgreSQLCafe.Entities;

namespace PostgreSQLCafe.Services.SliderService
{
    public class SliderService : ISliderService
    {
        private readonly CafeContext _context;
        public SliderService(CafeContext context)
        {
            _context = context;
        }
        public async Task<List<ResultSliderDto>> GetSliderListAsync()
        {
            var values= await _context.Sliders.ToListAsync();
            var result = values.Select(s => new ResultSliderDto
            {
                Id = s.Id,
                SliderImageUrl = s.SliderImageUrl
            }).ToList();
            return result;
        }
    }
}
