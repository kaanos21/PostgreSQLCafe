using PostgreSQLCafe.Dto.ChefDto;

namespace PostgreSQLCafe.Services.ChefService
{
    public interface IChefService
    {
        public Task<List<ResultChefWithSocialMediaDto>> GetChefWithSocialMediaAsync();
    }
}
