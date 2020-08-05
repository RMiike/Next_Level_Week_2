using Flunt.Notifications;
using Flunt.Validations;

namespace Proffy.Core.DTOs
{
    public class UserDTO : Notifiable, IValidatable
    {
        protected UserDTO() { }
        public UserDTO(int id, string name, string avatar, string whatsapp, string bio)
        {
            Id = id;
            Name = name;
            Avatar = avatar;
            Whatsapp = whatsapp;
            Bio = bio;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Whatsapp { get; set; }
        public string Bio { get; set; }

        public void Validate()
        {
            AddNotifications(
               new Contract()
               .Requires()
               .HasMaxLen(Name, 60, "Name", "This field should have no more than 60 chars.")
               .HasMinLen(Name, 3, "Name", "This field should have at least 3 chars.")
               .HasMaxLen(Avatar, 200, "Avatar", "This field should have no more than 200 chars.")
               .HasMinLen(Avatar, 6, "Avatar", "This field should have at least 6 chars.")
               .IsUrl(Avatar, "Avatar", "Should be a valid url.")
                .HasLen(Whatsapp, 11, "Whatsapp", "This field should have 11 chars.")
                 .HasMaxLen(Bio, 450, "Bio", "This field should have no more than 450 chars.")
               .HasMinLen(Bio, 6, "Bio", "This field should have at least 6 chars.")
                 );
        }
    }
}
