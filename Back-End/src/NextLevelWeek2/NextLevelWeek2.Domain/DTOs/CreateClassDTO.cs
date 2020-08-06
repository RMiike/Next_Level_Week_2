using Flunt.Notifications;
using Flunt.Validations;
using System.Collections.Generic;

namespace Proffy.Core.DTOs
{
    public class CreateClassDTO : Notifiable, IValidatable
    {
        protected CreateClassDTO()
        {

        }
        public CreateClassDTO(int classId, int userId, string subject, decimal cost, string name, string avatar, string whatsapp, string bio, IEnumerable<ScheduleDTO> schedule)
        {
            ClassId = classId;
            UserId = userId;
            Subject = subject;
            Cost = cost;
            Name = name;
            Avatar = avatar;
            Whatsapp = whatsapp;
            Bio = bio;
            Schedule = schedule;
        }

      
        public int ClassId { get; private set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Whatsapp { get; set; }
        public string Bio { get; set; }
        public IEnumerable<ScheduleDTO> Schedule { get; set; }

        public void Validate()
        {
            AddNotifications(
               new Contract()
               .Requires()
               .HasMaxLen(Subject, 60, "Name", "This field should have no more than 60 chars.")
               .HasMinLen(Subject, 3, "Name", "This field should have at least 3 chars.")
               .IsGreaterThan(Cost, 0, "Cost", "Should have a value,")
                 .HasMaxLen(Name, 60, "Name", "This field should have no more than 60 chars.")
               .HasMinLen(Name, 3, "Name", "This field should have at least 3 chars.")
               .HasMaxLen(Avatar, 450, "Avatar", "This field should have no more than 450 chars.")
               .HasMinLen(Avatar, 6, "Avatar", "This field should have at least 6 chars.")
               .IsUrl(Avatar, "Avatar", "Should be a valid url.")
               .HasLen(Whatsapp, 11, "Whatsapp", "This field should have 11 chars.")
               .HasMaxLen(Bio, 450, "Bio", "This field should have no more than 450 chars.")
               .HasMinLen(Bio, 6, "Bio", "This field should have at least 6 chars."));
        }
    }
    public class ScheduleDTO
    {
        public int ClassScheduleId { get; set; }
        public int WeekDay { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }

    public class ClassScheduleCreate
    {
        public ClassScheduleCreate(int classScheduleId, int weekDay, int from, int to)
        {
            ClassScheduleId = classScheduleId;
            WeekDay = weekDay;
            From = from;
            To = to;
        }
        public int ClassScheduleId { get; set; }
        public int WeekDay { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
}
