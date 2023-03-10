using System.ComponentModel.DataAnnotations;

namespace APIVentas.DataModel
{
    public class ProductoDataModel
    {
        [Key]
        public Guid idProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
        public bool estado { get; set; }
    }
}
