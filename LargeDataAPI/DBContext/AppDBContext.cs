using Microsoft.EntityFrameworkCore;

namespace LargeDataAPI.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set; }
    }
}
