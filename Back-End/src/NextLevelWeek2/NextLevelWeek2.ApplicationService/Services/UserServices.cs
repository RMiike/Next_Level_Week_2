using Proffy.Core.Contracts;
using Proffy.Core.DTOs;
using Proffy.Core.Entities;

namespace Proffy.ApplicationService.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ResultDTO Create(UserDTO userDTO)
        {
            userDTO.Validate();
            if (userDTO.Invalid)
                return new ResultDTO(false, "Invalid fields.", userDTO.Notifications);

            var userExistis = _userRepository.Get(userDTO.Name);
            if (userExistis != null)
                return new ResultDTO(false, "User already exist!", null);

            var user = User.Create(userDTO.Id, userDTO.Name, userDTO.Avatar, userDTO.Whatsapp, userDTO.Bio);
            if (_userRepository.Save())
                return new ResultDTO(true, "Successfuly registered.", user);

            return new ResultDTO(false, "Cannot be saved.", null);

        }
    }
}
