using Proyecto_SportZone;
using Microsoft.EntityFrameworkCore;

namespace Services.MyDbContext
{
    public class MyContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }

        public DbSet<Shoes> Shoes { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Proyecto_SportZone.Category> Categorias { get; set; }
        public DbSet<Cliente> Customers { get; set; }
    }
}
