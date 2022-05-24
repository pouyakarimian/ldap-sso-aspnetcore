using Microsoft.EntityFrameworkCore;
using TestAuth2Mvc.Models;

namespace TestAuth2Mvc.Data
{
    public class LdapContext : DbContext
    {
        public LdapContext(DbContextOptions<LdapContext> options)
            : base(options)
        {
        }

        public DbSet<MvcObject> MvcObject { get; set; }
    }
}