using Proffy.Core.DTOs;

namespace Proffy.Core.Contracts
{
    public interface ICreateClassServices
    {
        ResultDTO Create(CreateClassDTO createClassDTO);
        ResultDTO Index(int? week_day, string? subject, string? time);
    }
}
