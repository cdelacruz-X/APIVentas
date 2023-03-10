using System.ComponentModel.DataAnnotations;

namespace APIVentas.DataModel
{
    public class VendedorDataModel
    {
        [Key]
        public Guid idVendedor { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccion { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
    }
}
