using Microsoft.EntityFrameworkCore;
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

        public async Task AddReservationAsync(Reserva reservation)
        {
            await _context.Reservaciones.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReservationAsync(DateTime date)
        {
            var reservation = await _context.Reservaciones
           .FirstOrDefaultAsync(r => r.DiaReservacion == date);
            if (reservation != null)
            {
                _context.Reservaciones.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Reserva> GetReservationByIdAsync(int id)
        {
            return await _context.Reservaciones.FindAsync(id);
        }

        public async Task<IEnumerable<Reserva>> GetReservationsByFacilityIdAsync(int facilityId)
        {
            return await _context.Reservaciones
               .Where(r => r.EspaciosDeportivosId == facilityId)
               .ToListAsync();
        }

        public async Task<IEnumerable<Reserva>> GetAllReservationsAsync()
        {
            return await _context.Reservaciones.ToListAsync();
        }

        public async Task UpdateReservationAsync(Reserva reservation)
        {
            _context.Entry(reservation).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
