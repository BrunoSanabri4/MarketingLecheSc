namespace Marketing_Sc.DTOs
{
    public class CampaniaResumenDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string ProductoSolicitado { get; set; } = string.Empty;

        public int CantidadVendedores { get; set; }

    }
}
