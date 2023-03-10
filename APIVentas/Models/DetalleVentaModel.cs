namespace APIVentas.Models
{
    public class DetalleVentaModel
    {
        public Guid idVenta { get; set; }
        public Guid idProducto { get; set; }
        public float cantidad { get; set; }
        public float precio { get; set; }
    }
}
