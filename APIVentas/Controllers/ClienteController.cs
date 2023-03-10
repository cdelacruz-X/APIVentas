using APIVentas.DatabaseContext;
using APIVentas.DataModel;
using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DataBaseContext _databaseContext;

        public ClienteController(DataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("GetClienteList/")]
        public async Task<IActionResult> GetClienteList()
        {
            return Ok(_databaseContext.Producto.ToList());
        }
        [HttpPost]
        [Route("PostCliente/")]
        public async Task<IActionResult> PostCliente(ClienteModel cliente)
        {
            ClienteDataModel cli = new ClienteDataModel();
            cli.idCliente = Guid.NewGuid();
            cli.nombres = cliente.nombres;
            cli.apellidos = cliente.apellidos;
            cli.sexo = cliente.sexo;
            cli.fechaNacimiento = cliente.fechaNacimiento;
            cli.tipoDocumento = cliente.tipoDocumento;
            cli.numeroDocumento = cliente.numeroDocumento;
            cli.direccion = cliente.direccion;

            _databaseContext.Cliente.Add(cli);
            _databaseContext.SaveChanges();

            return Ok(cliente);
        }
    }
}
