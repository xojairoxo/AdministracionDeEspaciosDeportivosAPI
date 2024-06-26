using SportsFacilityManagementAPI.Data;
using SportsFacilityManagementAPI.Model;

namespace SportsFacilityManagementAPI.Repository
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly ApplicationDbContext _context;
        public ReservaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddReservationAsync(Reserva reservation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReservationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Reserva> GetReservationByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Reserva>> GetReservationsByFacilityIdAsync(int facilityId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReservationAsync(Reserva reservation)
        {
            throw new NotImplementedException();
        }
    }
}
