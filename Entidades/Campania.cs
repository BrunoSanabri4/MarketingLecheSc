namespace Marketing_Sc.Entidades
{
    public class Campania
    {
       
            public int Id { get; set; }

            // Información base
            public string Nombre { get; set; } = string.Empty;
            public string Descripcion { get; set; } = string.Empty;
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }

            // Estado de la campaña
            public string Estado { get; set; } = "Planificacion";

            // Gastos
            public decimal GastoAntes { get; set; }
            public decimal GastoDurante { get; set; }
            public decimal GastoDespues { get; set; }

            // Productos solicitados
            public int CantidadProductoSolicitado { get; set; }
            public string ProductoSolicitado { get; set; } = string.Empty;

            // Viáticos y caja chica
            public decimal ViaticosAsignados { get; set; }
            public decimal CajaChica { get; set; }

            // Combos creados
            public string CombosPromocionales { get; set; } = string.Empty;

            public int CantidadVendedores { get; set; }
        

    }
}
