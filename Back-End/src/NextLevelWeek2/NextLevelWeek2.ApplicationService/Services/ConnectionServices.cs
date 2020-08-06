using Proffy.Core.Contracts;
using Proffy.Core.DTOs;
using Proffy.Core.Entities;
using System.Linq;

namespace Proffy.ApplicationService.Services
{
    public class ConnectionServices : IConnectionServices
    {
        private readonly IConnectionRepository _connectionRepository;
        public ConnectionServices(IConnectionRepository connectionRepository)
        {
            _connectionRepository = connectionRepository;
        }
        public ResultDTO Create(ConnectionDTO connectionDTO)
        {
            connectionDTO.Validate();
            if (connectionDTO.Invalid)
                return new ResultDTO(false, "Invalid fields.", connectionDTO.Notifications);

            var connection = Connection.Create(connectionDTO.Id, connectionDTO.UserId);

            _connectionRepository.Create(connection);
            if (!_connectionRepository.Save())
                return new ResultDTO(false, "Cannot be saved.", null);

            return new ResultDTO(true, "Successfuly registered.", connection);
        }

        public ResultDTO Index()
        {
            var connections = _connectionRepository.Get().Count();
            return new ResultDTO(true, "All connections", connections);

        }
    }
}
