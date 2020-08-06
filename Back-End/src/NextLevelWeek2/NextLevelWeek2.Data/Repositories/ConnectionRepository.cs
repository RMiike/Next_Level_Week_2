using NextLevelWeek2.Data.Data;
using Proffy.Core.Contracts;
using Proffy.Core.Entities;

namespace Proffy.Data.Repositories
{
    public class ConnectionRepository : DefaultRepository<Connection>, IConnectionRepository
    {
        public ConnectionRepository(ProffyDbContext context) : base(context)
        {
        }
    }
}
