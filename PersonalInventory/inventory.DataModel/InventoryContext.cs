using Inventory.Domain;
using Microsoft.EntityFrameworkCore;

namespace Inventory.DataModel
{
    public class InventoryContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Possession> Possessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=inventory.db");
        }
    }
}
