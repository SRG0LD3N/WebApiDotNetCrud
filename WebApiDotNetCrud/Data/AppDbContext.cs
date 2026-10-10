
using Microsoft.EntityFrameworkCore;
using WebApiDotNetCrud.Models;

namespace WebApiDotNetCrud.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
