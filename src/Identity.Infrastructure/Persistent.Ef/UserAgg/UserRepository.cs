using Identity.Domain.UserAgg;
using Identity.Domain.UserAgg.Repository;
using Identity.Infrastructure.Core;
using Identity.Infrastructure.Utilities;

namespace Identity.Infrastructure.Persistent.Ef.UserAgg
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}