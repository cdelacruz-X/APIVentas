namespace APIVentas.Models
{
    public class VentaModel
    {
        public Guid idCliente { get; set; }
        public Guid idVendedor { get; set; }
        public DateTime fecha { get; set; }
        public string tipo_comprobante { get; set; }
        public string correlativo { get; set; }
        public bool estado { get; set; }
    }
}
