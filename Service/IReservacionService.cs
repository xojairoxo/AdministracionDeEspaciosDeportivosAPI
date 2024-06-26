using SportsFacilityManagementAPI.Model;

namespace SportsFacilityManagementAPI.Service
{
    public interface IReservacionService
    {
        Task<IEnumerable<Reserva>> GetReservationsByFacilityIdAsync(int facilityId);
        Task<Reserva> GetReservationByIdAsync(int id);
        Task AddReservationAsync(Reserva reservation);
        Task UpdateReservationAsync(Reserva reservation);
        Task DeleteReservationAsync(DateTime date);
        public Task<IEnumerable<Reserva>> GetAllReservationsAsync();
    }
}
