
namespace SportsFacilityManagementAPI.Model
{
    public class Reserva
    {
        public int Id { get; set; }
        public int EspacioDeportivoId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public EspacioDeportivo espacioDeportivo { get; set; }

    }
}
