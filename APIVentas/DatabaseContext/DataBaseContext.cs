using APIVentas.DataModel;
using Microsoft.EntityFrameworkCore;

namespace APIVentas.DatabaseContext
{
    public class DataBaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseInMemoryDatabase(databaseName: "DB_Ventas");
        }
        public DbSet<ClienteDataModel> Cliente { get; set; }
        public DbSet<DetalleVentaDataModel> DetalleVenta { get; set; }
        public DbSet<ProductoDataModel> Producto { get; set; }
        public DbSet<VendedorDataModel> Vendedor { get; set; }
        public DbSet<VentaDataModel> Ventas { get; set; }
        
    }
}
