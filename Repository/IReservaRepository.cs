using SportsFacilityManagementAPI.Model;
namespace SportsFacilityManagementAPI.Repository
{
    public interface IReservaRepository
    {
        Task<IEnumerable<Reserva>> GetReservationsByFacilityIdAsync(int facilityId);
        Task<Reserva> GetReservationByIdAsync(int id);
        Task AddReservationAsync(Reserva reservation);
        Task UpdateReservationAsync(Reserva reservation);
        Task DeleteReservationAsync(int id);
    }
}
}
