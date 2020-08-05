using Microsoft.EntityFrameworkCore;
using NextLevelWeek2.Data.Data;
using Proffy.Core.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proffy.Data.Repositories
{
    public class DefaultRepository<T> : IDefaultRepository<T> where T : class
    {
        private readonly ProffyDbContext _context;
        private DbSet<T> table = null;
        public DefaultRepository(ProffyDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void Create(T obj)
        {
            table.Add(obj);
        }

        public void Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await table.ToListAsync();
        }

        public T Get(int id)
        {
            return table.Find(id);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
