using PostgreSQLCafe.Dto.ReservationDto;

namespace PostgreSQLCafe.Services.ReservationService
{
    public interface IReservationService
    {
        public Task CreateReservationAsync(CreateReservationDto createReservationDto);
        public Task<List<ResultReservationDto>> ListReservationAsync();
    }
}
