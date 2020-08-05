using NextLevelWeek2.Data.Data;
using Proffy.Core.Contracts;
using Proffy.Core.DTOs;
using Proffy.Core.Entities;
using System.Linq;

namespace Proffy.Data.Repositories
{
    public class ClassRepository : DefaultRepository<Class>, IClassRepository
    {
        private readonly ProffyDbContext _context;
        public ClassRepository(ProffyDbContext context) : base(context)
        {
            _context = context;
        }
       
    }
}
