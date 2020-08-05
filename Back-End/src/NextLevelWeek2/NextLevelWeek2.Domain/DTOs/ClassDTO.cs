using Flunt.Notifications;
using Flunt.Validations;

namespace Proffy.Core.DTOs
{
    class ClassDTO : Notifiable, IValidatable
    {
        protected ClassDTO() { }
        public ClassDTO(int id, string subject, decimal cost, int userId)
        {
            Id = id;
            Subject = subject;
            Cost = cost;
            UserId = userId;
        }

        public int Id { get; private set; }
        public string Subject { get; set; }
        public decimal Cost { get; set; }
        public int UserId { get; set; }
        public void Validate()
        {
            AddNotifications(
               new Contract()
               .Requires()
               .HasMaxLen(Subject, 60, "Name", "This field should have no more than 60 chars.")
               .HasMinLen(Subject, 3, "Name", "This field should have at least 3 chars.")
               .IsGreaterThan(Cost, 0, "Cost", "Should have a value,")
               .IsGreaterThan(UserId, 0, "UserId", "Invalid user id"));
        }
    }
}
