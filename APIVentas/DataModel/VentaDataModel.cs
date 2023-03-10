using System.ComponentModel.DataAnnotations;

namespace APIVentas.DataModel
{
    public class VentaDataModel
    {
        [Key]
        public Guid idVenta { get; set; }
        public Guid idCliente { get; set; }
        public Guid idVendedor { get; set; }
        public DateTime fecha { get; set; }
        public string tipo_comprobante { get; set; }
        public string correlativo { get; set; }
        public bool estado { get; set; }
    }
}
