using Microsoft.AspNetCore.Mvc;
using SportsFacilityManagementAPI.Model;
using SportsFacilityManagementAPI.Service;

namespace SportsFacilityManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservacionService _reservationService;

        public ReservationController(IReservacionService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("EspacioDeportivo/{espacioDeportivoId}")]
        public async Task<IActionResult> GetReservationsByFacilityId(int espacioDeportivoId)
        => Ok(await _reservationService.GetReservationsByFacilityIdAsync(espacioDeportivoId));

        [HttpGet("GetAllReservations")]
        public async Task<IActionResult> GetAllReservations()
       =>  Ok(await _reservationService.GetAllReservationsAsync() );

        [HttpPost("/AgregarReservacion")]
        public async Task<IActionResult> AddReservation(Reserva reservation)
        {
            await _reservationService.AddReservationAsync(reservation);
            return CreatedAtAction(nameof(GetAllReservations), new { id = reservation.ReservaId }, reservation);
        }

        [HttpPut("/updateById/{id}")]
        public async Task<IActionResult> UpdateReservation(int id, Reserva reservation)
        {
            if (id != reservation.ReservaId)
                return BadRequest();

            await _reservationService.UpdateReservationAsync(reservation);
            return NoContent();
        }

        [HttpDelete("/deleteByDate/{date}")]
        public async Task<IActionResult> DeleteReservation(DateTime date)
        {
            await _reservationService.DeleteReservationAsync(date);
            return NoContent();
        }
    }
}