
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

        public DbSet<Entidades.Shoe> Shoes { get; set; }
        public DbSet<Entidades.Invoice> Invoices { get; set; }
        public DbSet<Entidades.Category> Categories { get; set; }
        public DbSet<Entidades.Customer> Customers { get; set; }
    }
}
