using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proffy.Core.Entities;

namespace Proffy.Data.Configurations
{
    public class ConnectionMaps : IEntityTypeConfiguration<Connection>
    {
        public void Configure(EntityTypeBuilder<Connection> builder)
        {
            builder.ToTable("Connection");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
              .HasColumnName("Id")
              .IsRequired();


            builder.Property(x => x.CreatedAt)
            .HasColumnName("CreatedAt")
            .IsRequired();



            builder.Property(x => x.UserId)
            .HasColumnName("UserId")
            .IsRequired();


            builder.HasOne(x => x.User)
                .WithMany(x => x.Connections)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
