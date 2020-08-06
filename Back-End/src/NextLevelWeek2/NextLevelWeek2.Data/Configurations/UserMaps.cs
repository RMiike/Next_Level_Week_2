using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proffy.Core.Entities;

namespace Proffy.Data.Configurations
{
    public class UserMaps : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("ProffyUser");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
              .HasColumnName("Id")
              .IsRequired();


            builder.Property(x => x.Name)
            .HasColumnName("Name")
             .HasMaxLength(60)
             .HasColumnType("varchar(60)")
            .IsRequired();


            builder.Property(x => x.Avatar)
            .HasColumnName("Avatar")
             .HasMaxLength(200)
             .HasColumnType("varchar(200)")
            .IsRequired();


            builder.Property(x => x.Whatsapp)
            .HasColumnName("Whatsapp")
             .HasMaxLength(11)
             .HasColumnType("varchar(11)")
            .IsRequired();


            builder.Property(x => x.Bio)
            .HasColumnName("Bio")
             .HasMaxLength(60)
             .HasColumnType("varchar(450)")
            .IsRequired();

        }
    }
}
