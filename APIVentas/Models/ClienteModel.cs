namespace APIVentas.Models
{
    public class ClienteModel
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string direccion { get; set; }
    }
}
