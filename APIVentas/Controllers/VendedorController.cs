using APIVentas.DatabaseContext;
using APIVentas.DataModel;
using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly DataBaseContext _databaseContext;

        public VendedorController(DataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("GetVendedorList/")]
        public async Task<IActionResult> GetVendedorList()
        {
            return Ok(_databaseContext.Vendedor.ToList());
        }
        [HttpPost]
        [Route("PostVenta/")]
        public async Task<IActionResult> PostVendedor(VendedorModel vendedor)
        {
            VendedorDataModel ven = new VendedorDataModel();
            ven.idVendedor = Guid.NewGuid();
            ven.nombres = vendedor.nombres;
            ven.apellidos = vendedor.apellidos;
            ven.sexo = vendedor.sexo;
            ven.fechaNacimiento = vendedor.fechaNacimiento;
            ven.numeroDocumento = vendedor.numeroDocumento;
            ven.direccion = vendedor.direccion;
            ven.usuario = vendedor.usuario;
            ven.password = vendedor.password;

            _databaseContext.Vendedor.Add(ven);
            _databaseContext.SaveChanges();

            return Ok(vendedor);
        }
    }
}
