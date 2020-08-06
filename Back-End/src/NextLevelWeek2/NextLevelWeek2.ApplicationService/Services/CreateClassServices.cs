using NextLevelWeek2.Data.Data;
using Proffy.ApplicationService.Utils;
using Proffy.Core.Contracts;
using Proffy.Core.DTOs;
using Proffy.Core.Entities;
using System;
using System.Linq;

namespace Proffy.ApplicationService.Services
{
    public class CreateClassServices : ICreateClassServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IClassRepository _classRepository;
        private readonly IClassScheduleRepository _classScheduleRepository;
        private readonly ProffyDbContext _context;

        public CreateClassServices(
            IClassRepository classRepository,
            IUserRepository userRepository,
            IClassScheduleRepository classScheduleRepository,
            ProffyDbContext proffyDbContext
           )
        {
            _classRepository = classRepository;
            _userRepository = userRepository;
            _classScheduleRepository = classScheduleRepository;
            _context = proffyDbContext;
        }
        public ResultDTO Create(CreateClassDTO createClassDTO)
        {
            createClassDTO.Validate();
            if (createClassDTO.Invalid)
                return new ResultDTO(false, "Invalid fields.", createClassDTO.Notifications);
            try
            {

            using (var transaction = _context.Database.BeginTransaction())
            {

                var userExistis = _userRepository.Get(createClassDTO.Name);
                if (userExistis != null)
                    return new ResultDTO(false, "User already exist!", null);

                var user = User.Create(createClassDTO.UserId, createClassDTO.Name, createClassDTO.Avatar, createClassDTO.Whatsapp, createClassDTO.Bio);
                _userRepository.Create(user);
                if (!_userRepository.Save())
                    return new ResultDTO(false, "Cannot be saved.", null);

                var classese = Class.Create(createClassDTO.ClassId, createClassDTO.Subject, createClassDTO.Cost, user.Id);
                _classRepository.Create(classese);
                if (!_classRepository.Save())
                    return new ResultDTO(false, "Cannot be saved.", null);


                foreach (var item in createClassDTO.Schedule)
                {
                    var classSchedule = ClassSchedule.Create(
                      item.ClassScheduleId,
                       item.WeekDay,
                       ConvertHours.ToMinute(item.From),
                       ConvertHours.ToMinute(item.To),
                       classese.Id);
                    _classScheduleRepository.Create(classSchedule);
                }
                if (!_classRepository.Save())
                    return new ResultDTO(false, "Cannot be saved.", null);

                transaction.Commit();
                return new ResultDTO(true, "Successfuly registered.", null);
            }
            }
            catch(Exception e)
            {
                return new ResultDTO(false, "Cannot be saved.", e);
            }
        }

        public ResultDTO Index(int? week_day, string subject, string time)
        {

            if (week_day == null || String.IsNullOrEmpty(subject) || String.IsNullOrEmpty(time))
                return new ResultDTO(false, "Invalid fields.", null);

            var timeInMinutes = ConvertHours.ToMinute(time);

            var classes = _context.ClassSchedules
                .Where(x=> x.WeekDay == week_day && x.From <= timeInMinutes && x.To >= timeInMinutes)
                .Select(x=> x.Class)
                .Where(x => x.Subject == subject)
                .Select( x => new ReadClassDTO(x.Id, x.Subject, x.Cost, x.UserId, x.User)).ToArray();


            return new ResultDTO(true, "Lista", classes);
        }
    }
}
