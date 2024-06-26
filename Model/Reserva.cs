
namespace SportsFacilityManagementAPI.Model
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int EspaciosDeportivosId { get; set; }
        public DateTime DiaReservacion { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFinal { get; set; }
    }
}
