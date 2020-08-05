using NextLevelWeek2.Data.Data;
using Proffy.Core.Contracts;
using Proffy.Core.Entities;

namespace Proffy.Data.Repositories
{
    public class ClassRepository : DefaultRepository<Class>, IClassRepository
    {
        public ClassRepository(ProffyDbContext context) : base(context)
        {
        }
    }
}
