using Identity.Domain.RoleAgg;
using Identity.Infrastructure.Core;
using Identity.Infrastructure.Utilities;
using Shop.Domain.RoleAgg.Repository;

namespace Identity.Infrastructure.Persistent.Ef.RoleAgg;

internal class RoleRepository : BaseRepository<Role>, IRoleRepository
{
    public RoleRepository(ApplicationDbContext context) : base(context)
    {
    }
}