using Microsoft.EntityFrameworkCore;
using SportsFacilityManagementAPI.Model;
using SportsFacilityManagementAPI.Repository;

namespace SportsFacilityManagementAPI.Service
{
    public class ReservacionService : IReservacionService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservacionService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }
        public async Task AddReservationAsync(Reserva reservation) => await _reservaRepository.AddReservationAsync(reservation);
    
        public async Task DeleteReservationAsync(DateTime date) => await _reservaRepository.DeleteReservationAsync(date);

        public async Task<Reserva> GetReservationByIdAsync(int id) => await _reservaRepository.GetReservationByIdAsync(id);

        public async Task<IEnumerable<Reserva>> GetReservationsByFacilityIdAsync(int facilityId) => await _reservaRepository.GetReservationsByFacilityIdAsync(facilityId);

        public async Task UpdateReservationAsync(Reserva reservation) => await _reservaRepository.UpdateReservationAsync(reservation);
        public async Task<IEnumerable<Reserva>> GetAllReservationsAsync() => await _reservaRepository.GetAllReservationsAsync();
            

    }
}
