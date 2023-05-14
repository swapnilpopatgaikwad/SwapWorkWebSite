using Microsoft.EntityFrameworkCore;

namespace SwapWorkWebSite.Data
{
    public class SwapWorkWebSiteContext : DbContext
    {
        public SwapWorkWebSiteContext (DbContextOptions<SwapWorkWebSiteContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
    }
}
