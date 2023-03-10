using APIVentas.DatabaseContext;
using APIVentas.DataModel;
using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleVentaController : ControllerBase
    {
        private readonly DataBaseContext _databaseContext;

        public DetalleVentaController(DataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("GetDetalleVentaList/")]
        public async Task<IActionResult> GetDetalleVentaList()
        {
            return Ok(_databaseContext.DetalleVenta.ToList());
        }
        [HttpPost]
        [Route("PostDetalleVenta/")]
        public async Task<IActionResult> PostDetalleVenta(DetalleVentaModel detalleVenta)
        {
            DetalleVentaDataModel det_Venta = new DetalleVentaDataModel();
            det_Venta.idDetalle_Venta = Guid.NewGuid();
            det_Venta.idVenta = detalleVenta.idVenta;
            det_Venta.idProducto = detalleVenta.idProducto;
            det_Venta.cantidad = detalleVenta.cantidad;
            det_Venta.precio = detalleVenta.precio;

            _databaseContext.DetalleVenta.Add(det_Venta);
            _databaseContext.SaveChanges();

            return Ok(detalleVenta);
        }
    }
}
