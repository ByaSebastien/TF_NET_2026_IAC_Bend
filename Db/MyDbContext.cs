using Microsoft.EntityFrameworkCore;

namespace TF_NET_2026_IAC_Bend.Db
{
    public class MyDbContext: DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
        }
    }
}
