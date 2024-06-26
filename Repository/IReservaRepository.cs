using SportsFacilityManagementAPI.Model;
namespace SportsFacilityManagementAPI.Repository
{
    public interface IReservaRepository
    {
        Task<IEnumerable<Reserva>> GetReservationsByFacilityIdAsync(int facilityId); // Interfaz para los metodos de reservacion
        Task<Reserva> GetReservationByIdAsync(int id);
        Task AddReservationAsync(Reserva reservation);
        Task UpdateReservationAsync(Reserva reservation);
        Task DeleteReservationAsync(DateTime date);
        public Task<IEnumerable<Reserva>> GetAllReservationsAsync();
    }

}
