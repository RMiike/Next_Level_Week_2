using Proffy.Core.DTOs;

namespace Proffy.Core.Contracts
{
    public interface IConnectionServices
    {
        ResultDTO Create(ConnectionDTO connectionDTO);
        ResultDTO Index();
    }
}
