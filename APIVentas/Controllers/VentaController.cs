using APIVentas.DatabaseContext;
using APIVentas.DataModel;
using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly DataBaseContext _databaseContext;

        public VentaController(DataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("GetVentaList/")]
        public async Task<IActionResult> GetVentaList()
        {
            var queryVenta = (from vt in _databaseContext.Ventas
                     join cl in _databaseContext.Cliente on vt.idCliente equals cl.idCliente
                     join vd in _databaseContext.Vendedor on vt.idVendedor equals vd.idVendedor
                     join dv in _databaseContext.DetalleVenta on vt.idVenta equals dv.idVenta
                     join pd in _databaseContext.Producto on dv.idProducto equals pd.idProducto
                     //orderby dv.OrderID
                     select new
                     {
                         vt.idVenta,
                         cliNombre=cl.nombres,
                         cliApellidos=cl.apellidos,
                         venNombre = vd.nombres,
                         venApellidos = vd.apellidos,
                         vt.fecha,
                         vt.tipo_comprobante,
                         vt.correlativo,
                         detalleRegistro=dv,
                         vt.estado 
                     }).ToList();

            return Ok(queryVenta.ToList());
        }
        [HttpPost]
        [Route("PostVenta/")]
        public async Task<IActionResult> PostVenta(VentaModel venta)
        {
            VentaDataModel ven = new VentaDataModel();
            ven.idVenta = Guid.NewGuid();
            ven.idCliente = venta.idCliente;
            ven.idVendedor = venta.idVendedor;
            ven.fecha = venta.fecha;
            ven.tipo_comprobante = venta.tipo_comprobante;
            ven.correlativo = venta.correlativo;
            ven.estado = venta.estado;

            _databaseContext.Ventas.Add(ven);
            _databaseContext.SaveChanges();

            return Ok(venta);
        }
    }
}
