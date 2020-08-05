using Proffy.Core.Entities;
using System.Collections.Generic;

namespace Proffy.Core.DTOs
{
    public class ReadClassDTO
    {
        public ReadClassDTO(int id, string subject, decimal cost, int userId, User user)
        {
            Id = id;
            Subject = subject;
            Cost = cost;
            UserId = userId;
            User = user;
        }

        public int Id { get;  set; }
        public string Subject { get;  set; }
        public decimal Cost { get;  set; }
        public int UserId { get;  set; }
        public User User { get;  set; }
    }
}
