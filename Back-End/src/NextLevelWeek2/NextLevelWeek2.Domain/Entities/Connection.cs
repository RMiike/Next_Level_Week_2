using NextLevelWeek2.Core.Entities;
using System;

namespace Proffy.Core.Entities
{
    public class Connection
    {
        protected Connection() { }
        private Connection(int id, DateTime createdAt, int userId)
        {
            Id = id;
            CreatedAt = createdAt;
            UserId = userId;
        }
        public static Connection Create(int id, DateTime createdAt, int userId)
        {
            return new Connection(id, createdAt, userId);
        }
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int UserId { get; private set; }
        public User User{ get; private set; }
    }
}
