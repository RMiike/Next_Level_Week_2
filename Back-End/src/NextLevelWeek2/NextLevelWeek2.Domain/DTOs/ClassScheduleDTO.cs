using Flunt.Notifications;
using Flunt.Validations;

namespace Proffy.Core.DTOs
{
    public class ClassScheduleDTO : Notifiable, IValidatable
    {
        protected ClassScheduleDTO()        {        }
        public ClassScheduleDTO(int id, int weekDay, int from, int to, int classId)
        {
            Id = id;
            WeekDay = weekDay;
            From = from;
            To = to;
            ClassId = classId;
        }

        public int Id { get; private set; }
        public int WeekDay { get;  set; }
        public int From { get;  set; }
        public int To { get;  set; }
        public int ClassId { get;  set; }
        public void Validate()
        {

            AddNotifications(
               new Contract()
                .IsBetween(WeekDay, 0, 6, "Weekday", "The value must be between 0 and 6")
                .IsBetween(From, 0, 23, "From", "The value must be between 0 and 23")
                .IsBetween(To, From, 23, "To", "The value must be between 0 and 23")
                .IsGreaterThan(ClassId, 0, "ClassId", "The value must be a valid class id.")
                 );
        }
    }
}
