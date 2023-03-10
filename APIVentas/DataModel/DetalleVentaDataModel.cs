using System.ComponentModel.DataAnnotations;

namespace APIVentas.DataModel
{
    public class DetalleVentaDataModel
    {
        [Key]
        public Guid idDetalle_Venta { get; set; }
        public Guid idVenta { get; set; }
        public Guid idProducto { get; set; }
        public float cantidad { get; set; }
        public float precio { get; set; }
    }
}
