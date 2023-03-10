using APIVentas.DatabaseContext;
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
            return Ok(_databaseContext.Ventas.ToList());
        } 
    }
}
