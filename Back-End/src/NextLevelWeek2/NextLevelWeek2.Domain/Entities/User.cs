using Proffy.Core.Entities;
using System.Collections.Generic;

namespace NextLevelWeek2.Core.Entities
{
    public class User
    {
        protected User() { }
        private User(int id, string name, string avatar, string whatsapp, string bio)
        {
            Id = id;
            Name = name;
            Avatar = avatar;
            Whatsapp = whatsapp;
            Bio = bio;
        }

        public static User Create(int id, string name, string avatar, string whatsapp, string bio)
        {
            return new User(id, name, avatar, whatsapp, bio);
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Avatar { get; private set; }
        public string Whatsapp { get; private set; }
        public string Bio { get; private set; }
        public IEnumerable<Class> Classes{ get; private set; }
    }
}
