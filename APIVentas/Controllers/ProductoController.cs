using APIVentas.DatabaseContext;
using APIVentas.DataModel;
using APIVentas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DataBaseContext _databaseContext;

        public ProductoController(DataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("GetProductoList/")]
        public async Task<IActionResult> GetProductoList()
        {
            return Ok(_databaseContext.Producto.ToList());
        }
        [HttpPost]
        [Route("PostProducto/")]
        public async Task<IActionResult> PostProducto(ProductoModel producto)
        {
            ProductoDataModel prod= new ProductoDataModel();
            prod.idProducto=Guid.NewGuid();
            prod.codigo = producto.codigo;
            prod.nombre = producto.nombre;
            prod.descripcion = producto.descripcion;
            prod.precio=producto.precio;
            prod.estado = producto.estado;

            _databaseContext.Producto.Add(prod);
            _databaseContext.SaveChanges();

            return Ok(producto);
        }
    }
}
