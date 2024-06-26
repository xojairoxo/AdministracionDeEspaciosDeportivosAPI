using SportsFacilityManagementAPI.Model;

namespace SportsFacilityManagementAPI.Repository
{
    public interface IEspacioDeportivoRepository
    {
        Task<IEnumerable<EspacioDeportivo>> GetAllFacilitiesAsync();
        Task<EspacioDeportivo> GetFacilityByIdAsync(int id);
        Task AddFacilityAsync(EspacioDeportivo facility);
        Task UpdateFacilityAsync(EspacioDeportivo facility);
        Task DeleteFacilityAsync(int id);
    }
}
