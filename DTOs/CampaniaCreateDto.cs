namespace Marketing_Sc.DTOs
{
    public class CampaniaCreateDto
    {
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public decimal GastoAntes { get; set; }
        public decimal GastoDurante { get; set; }
        public decimal GastoDespues { get; set; }

        public int CantidadProductoSolicitado { get; set; }
        public string ProductoSolicitado { get; set; } = string.Empty;

        public decimal ViaticosAsignados { get; set; }
        public decimal CajaChica { get; set; }

        public string CombosPromocionales { get; set; } = string.Empty;

        public int CantidadVendedores { get; set; }
    }
}
