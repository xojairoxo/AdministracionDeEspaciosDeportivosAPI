using SportsFacilityManagementAPI.Model;

namespace SportsFacilityManagementAPI.Service
{
    public interface IEspacioDeportivoService
    {
        Task<IEnumerable<EspacioDeportivo>> GetAllFacilitiesAsync();
        Task<EspacioDeportivo> GetFacilityByIdAsync(int id);
        Task AddFacilityAsync(EspacioDeportivo facility);
        Task UpdateFacilityAsync(EspacioDeportivo facility);
        Task DeleteFacilityAsync(int id);
    }
}
