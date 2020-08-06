using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Proffy.Core.DTOs
{
    public class ConnectionDTO : Notifiable, IValidatable
    {
        protected ConnectionDTO() { }
        public ConnectionDTO(int id, int userId, DateTime createdAt)
        {
            Id = id;
            UserId = userId;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int UserId { get; set; }
        public void Validate()
        {

            AddNotifications(
                   new Contract()
                   .Requires()
                   .IsGreaterThan(UserId, 0, "UserId", "Invalid user id."));
        }
    }
}
