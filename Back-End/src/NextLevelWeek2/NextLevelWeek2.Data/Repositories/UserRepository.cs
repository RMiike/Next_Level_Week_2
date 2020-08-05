using NextLevelWeek2.Data.Data;
using Proffy.Core.Contracts;
using Proffy.Core.Entities;

namespace Proffy.Data.Repositories
{
    public class UserRepository : DefaultRepository<User>, IUserRepository
    {
        public UserRepository(ProffyDbContext context) : base(context)
        {
        }
    }
}
