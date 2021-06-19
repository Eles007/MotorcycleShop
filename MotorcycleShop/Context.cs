using Microsoft.EntityFrameworkCore;

namespace MotorcycleShop
{
    public class AppContext : DbContext
    {
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Company> Companies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MotorcycleShop;Trusted_Connection=True;");
        }
    }
}
