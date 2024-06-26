namespace SportsFacilityManagementAPI.Model
{
    public class EspacioDeportivo
    {
        public int EspaciosDeportivosId { get; set; }
        public string Nombre { get; set; }
        public string Locacion { get; set; }
        public string Descripcion { get; set; }

        public int Capacidad { get; set; }
    }
}
