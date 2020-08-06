using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proffy.Core.Contracts
{
    public interface IDefaultRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Create( T obj);
        void Update(T obj);
        void Delete(int id);
        bool Save();
    }
}
