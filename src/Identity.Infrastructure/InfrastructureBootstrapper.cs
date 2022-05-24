using Identity.Domain.UserAgg.Repository;
using Identity.Infrastructure.Core;
using Identity.Infrastructure.Persistent.Ef.RoleAgg;
using Identity.Infrastructure.Persistent.Ef.UserAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop.Domain.RoleAgg.Repository;

namespace Identity.Infrastructure
{
    public class InfrastructureBootstrapper
    {
        public static void Init(IServiceCollection services,string connectionString)
        {
           
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
        }
    }
}