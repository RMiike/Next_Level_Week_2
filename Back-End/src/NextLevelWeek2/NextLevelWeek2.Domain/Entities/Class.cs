using NextLevelWeek2.Core.Entities;
using System;

namespace Proffy.Core.Entities
{
    public class Class
    {
        protected Class()       {        }
        private Class(int id, string subject, decimal cost, int userId, User user)
        {
            Id = id;
            Subject = subject;
            Cost = cost;
            UserId = userId;
            User = user;
        }
        public static Class Create(int id, string subject, decimal cost, int userId, User user)
        {
            return new Class(id, subject, cost, userId, user);
        }
        public int Id { get; private set; }
        public string Subject { get; private set; }
        public decimal Cost { get; private set; }
        public int UserId{ get; private set; }
        public User User { get; private set; }
    }
}
