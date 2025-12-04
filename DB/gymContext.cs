using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class gymContext : DbContext
    {
        public gymContext(DbContextOptions<gymContext> options)
            : base(options)
        {
        }

        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Membresia> Membresias { get; set; }
    }
}
