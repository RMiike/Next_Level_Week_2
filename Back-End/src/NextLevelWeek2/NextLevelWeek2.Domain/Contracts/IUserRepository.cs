using Proffy.Core.Entities;

namespace Proffy.Core.Contracts
{
    public interface IUserRepository : IDefaultRepository<User>
    {
        User Get(string name);
    }
}
