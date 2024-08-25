using Humanizer;
using Microsoft.AspNetCore.Mvc;
using PostgreSQLCafe.Dto.ReservationDto;
using PostgreSQLCafe.Services.ReservationService;

namespace PostgreSQLCafe.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IReservationService _reservationService;

        public DefaultController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public async Task<IActionResult> MakeReservation(CreateReservationDto dto)
        {
            if (ModelState.IsValid)
            {
                await _reservationService.CreateReservationAsync(dto);
                return Json(new { success = true, message = "Reservation made successfully!" });
            }

            return Json(new { success = false, message = "Invalid data" });
        }
        [HttpGet]
        public IActionResult Denemereservasyon()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Denemereservasyon(CreateReservationDto createReservationDto)
        {
            if (ModelState.IsValid)
            {
                await _reservationService.CreateReservationAsync(createReservationDto);
                return View("BAŞARILI");
            }
            return View("BAŞARISIZ");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
