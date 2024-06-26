using Microsoft.AspNetCore.Mvc;
using SportsFacilityManagementAPI.Model;
using SportsFacilityManagementAPI.Service;

namespace SportsFacilityManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EspacioDeportivoController : ControllerBase
    {
        private readonly IEspacioDeportivoService _service;

        public EspacioDeportivoController(IEspacioDeportivoService service)
        {
            _service  = service;
        }

        [HttpGet(Name = "GetAllEspaciosDeportivos")]
        public async Task<IActionResult> GetAllEspaciosDeportivos() => Ok(await _service.GetAllFacilitiesAsync());

        [HttpPost(Name = "AddEspacioDeportivo")]
        public async Task<IActionResult> AddFacility(EspacioDeportivo facility)
        {
            await _service.AddFacilityAsync(facility);
            return CreatedAtAction(nameof(GetAllEspaciosDeportivos), new { id = facility.EspaciosDeportivosId }, facility);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFacility(int id, EspacioDeportivo facility)
        {
            if (id != facility.EspaciosDeportivosId)
                return BadRequest();

            await _service.UpdateFacilityAsync(facility);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacility(int id)
        {
            await _service.DeleteFacilityAsync(id);
            return NoContent();
        }

    }
}
