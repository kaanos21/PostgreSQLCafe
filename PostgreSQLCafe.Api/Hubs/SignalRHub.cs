using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using PostgreSQLCafe.Context;
using PostgreSQLCafe.Dto.ReservationDto;

namespace PostgreSQLCafe.Api.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly CafeContext _context;
        public SignalRHub(CafeContext context)
        {
            _context = context;
        }
        public async Task TotalProductCount()
        {
            try
            {
                var value = _context.Products.Count(); // Bu satırda hata olup olmadığını kontrol edin
                await Clients.All.SendAsync("ReceiveTotalProductCount", value);
            }
            catch (Exception ex)
            {
                // Hatayı loglayın veya daha fazla bilgi sağlayın
                Console.WriteLine($"TotalProductCount metodu hatası: {ex.Message}");
                throw; // Hatanın yakalanıp fırlatıldığından emin olun
            }
        }
        public async Task TotalReservationCount()
        {
            var value2 = _context.Reservations.Count();
            await Clients.All.SendAsync("ReceiveTotalReservationCount", value2);
        }
        public async Task TotalChefCount()
        {
            var value3 = _context.Chefs.Count();
            await Clients.All.SendAsync("ReceiveTotalChefCount", value3);
        }
        public async Task TotalCategoryCount()
        {
            var value4 = _context.Categories.Count();
            await Clients.All.SendAsync("ReceiveTotalCategoryCount", value4);
        }
        public async Task GetReservationListAsync()
        {
            var reservations = await _context.Reservations.ToListAsync();
            await Clients.All.SendAsync("ReceiveReservationList", reservations);
        }
    }
}
