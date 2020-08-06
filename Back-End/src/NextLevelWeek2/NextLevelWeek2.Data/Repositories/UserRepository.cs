using NextLevelWeek2.Data.Data;
using Proffy.Core.Contracts;
using Proffy.Core.Entities;
using System.Linq;

namespace Proffy.Data.Repositories
{
    public class UserRepository : DefaultRepository<User>, IUserRepository
    {
        private readonly ProffyDbContext _context;
        public UserRepository(ProffyDbContext context) : base(context)
        {
            _context = context;
        }

        public User Get(string name)
        {
            return _context.Users.Where(x => x.Name == name).FirstOrDefault();
        }

    }
}
