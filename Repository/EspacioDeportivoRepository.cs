using Microsoft.EntityFrameworkCore;
using SportsFacilityManagementAPI.Data;
using SportsFacilityManagementAPI.Model;

namespace SportsFacilityManagementAPI.Repository
{
    public class EspacioDeportivoRepository : IEspacioDeportivoRepository
    {
        private readonly ApplicationDbContext _context;
        public EspacioDeportivoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EspacioDeportivo>> GetAllFacilitiesAsync()
        {
            return await _context.EspacioDeportivo.ToListAsync();
        }

        public async Task<EspacioDeportivo> GetFacilityByIdAsync(int id)
        {
            return await _context.EspacioDeportivo.FindAsync(id);
        }
        public async Task UpdateFacilityAsync(EspacioDeportivo facility)
        {
            _context.Entry(facility).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFacilityAsync(int id)
        {
            var facility = await _context.EspacioDeportivo.FindAsync(id);
            if (facility != null)
            {
                _context.EspacioDeportivo.Remove(facility);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddFacilityAsync(EspacioDeportivo facility)
        {
            await _context.EspacioDeportivo.AddAsync(facility);
            await _context.SaveChangesAsync();
        }
    }
}
