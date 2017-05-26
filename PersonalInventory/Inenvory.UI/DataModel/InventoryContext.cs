using Inventory.Domain;
using Microsoft.EntityFrameworkCore;

namespace Inventory.DataModel
{
    public class InventoryContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Possession> Possessions { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<OwnerTodos> OwnerTodos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=inventory.db");
        }
    }
}
