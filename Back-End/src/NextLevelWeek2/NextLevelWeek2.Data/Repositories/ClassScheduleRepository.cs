using NextLevelWeek2.Data.Data;
using Proffy.Core.Contracts;
using Proffy.Core.Entities;

namespace Proffy.Data.Repositories
{
    public class ClassScheduleRepository : DefaultRepository<ClassSchedule>, IClassScheduleRepository
    {
        public ClassScheduleRepository(ProffyDbContext context) : base(context)
        {
        }
    }
}
