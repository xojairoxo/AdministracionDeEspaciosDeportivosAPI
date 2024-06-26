using SportsFacilityManagementAPI.Model;
using SportsFacilityManagementAPI.Repository;

namespace SportsFacilityManagementAPI.Service
{

    public class EspacioDeportivoService : IEspacioDeportivoService
    {
        private readonly IEspacioDeportivoRepository _EspacioDeportivoRepository;

        public EspacioDeportivoService(IEspacioDeportivoRepository EspacioDeportivoRepository)
        {
            _EspacioDeportivoRepository = EspacioDeportivoRepository;
        }

        public async Task<IEnumerable<EspacioDeportivo>> GetAllFacilitiesAsync() => await _EspacioDeportivoRepository.GetAllFacilitiesAsync();
        public async Task<EspacioDeportivo> GetFacilityByIdAsync(int id) => await _EspacioDeportivoRepository.GetFacilityByIdAsync(id);
        public async Task AddFacilityAsync(EspacioDeportivo facility) => await _EspacioDeportivoRepository.AddFacilityAsync(facility);
        public async Task UpdateFacilityAsync(EspacioDeportivo facility) => await _EspacioDeportivoRepository.UpdateFacilityAsync(facility);
        public async Task DeleteFacilityAsync(int id) => await _EspacioDeportivoRepository.DeleteFacilityAsync(id);
    }

}
