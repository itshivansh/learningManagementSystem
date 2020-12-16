using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.models
{
    #region Context
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
    #endregion
}
