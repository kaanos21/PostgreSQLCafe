namespace PostgreSQLCafe.Dto.StatisticService
{
    public interface IStatisticService
    {
        public Task<int> RezervationCount();
        public Task<int> ProductCount();
        public Task<int> CategoryCount();
        public Task<int> ChefCount();
    }
}
