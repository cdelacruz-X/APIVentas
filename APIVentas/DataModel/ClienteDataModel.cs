using System.ComponentModel.DataAnnotations;

namespace APIVentas.DataModel
{
    public class ClienteDataModel
    {
        [Key]
        public Guid idCliente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccion { get; set; }

    }
}
