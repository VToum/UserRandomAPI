using Microsoft.EntityFrameworkCore;
using UserRandomAPI.Entity;

namespace UserRandomAPI.Dao
{
    public class DaoContext : DbContext
    {
        public DaoContext(DbContextOptions<DaoContext> options) : base (options) { }
        
        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
