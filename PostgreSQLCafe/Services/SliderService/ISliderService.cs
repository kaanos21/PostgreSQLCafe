using PostgreSQLCafe.Dto.SliderDto;

namespace PostgreSQLCafe.Services.SliderService
{
    public interface ISliderService
    {
        public Task<List<ResultSliderDto>> GetSliderListAsync();
    }
}
