using Identity.Domain.RoleAgg;
using Identity.Domain.UserAgg;
using Identity.Infrastructure.Persistent.Ef.RoleAgg;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infrastructure.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(RoleConfiguration).Assembly);
        }
    }
}