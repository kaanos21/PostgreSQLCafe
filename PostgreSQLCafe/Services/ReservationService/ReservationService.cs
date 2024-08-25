using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Context;
using PostgreSQLCafe.Dto.ReservationDto;
using PostgreSQLCafe.Entities;

namespace PostgreSQLCafe.Services.ReservationService
{
    public class ReservationService : IReservationService
    {
        private readonly CafeContext _context;

        public ReservationService(CafeContext context)
        {
            _context = context;
        }

        public async Task CreateReservationAsync(CreateReservationDto createReservationDto)
        {
            var reservation = new Reservation
            {
                Name = createReservationDto.Name,
                Mail = createReservationDto.Mail,
                PhoneNumber = createReservationDto.PhoneNumber,
                GuestCount = createReservationDto.GuestCount,
                Date = createReservationDto.Date.ToUniversalTime(),
                Time = createReservationDto.Time,
                ReservationMessage = createReservationDto.ReservationMessage
            };
            await _context.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ResultReservationDto>> ListReservationAsync()
        {
            var vv= await _context.Reservations.ToListAsync();
            var result = vv.Select(r => new ResultReservationDto
            {
                Date = r.Date,
                GuestCount=r.GuestCount,
                Id = r.Id,
                Mail = r.Mail,
                Name = r.Name,
                PhoneNumber=r.PhoneNumber,
                ReservationMessage=r.ReservationMessage,
                Time = r.Time,
            }).ToList();
            return result;
        }
    }
}
