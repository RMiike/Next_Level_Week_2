using Proffy.Core.DTOs;

namespace Proffy.Core.Contracts
{
    public interface IUserServices
    {
        ResultDTO Create(UserDTO userDTO);
    }
}
