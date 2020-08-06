using System.Collections.Generic;

namespace Proffy.Core.Entities
{
    public class Class
    {
        protected Class() { }
        private Class(int id, string subject, decimal cost, int userId)
        {
            Id = id;
            Subject = subject;
            Cost = cost;
            UserId = userId;
        }
        public static Class Create(int id, string subject, decimal cost, int userId)
        {
            return new Class(id, subject, cost, userId);
        }
        public int Id { get; private set; }
        public string Subject { get; private set; }
        public decimal Cost { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public IEnumerable<ClassSchedule> ClassSchedules { get; private set; }

    }
}
