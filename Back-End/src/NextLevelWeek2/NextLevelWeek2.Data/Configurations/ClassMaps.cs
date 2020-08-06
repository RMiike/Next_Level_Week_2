using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proffy.Core.Entities;

namespace Proffy.Data.Configurations
{
    class ClassMaps : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
              .HasColumnName("Id")
              .IsRequired();


            builder.Property(x => x.Subject)
            .HasColumnName("Subject")
             .HasMaxLength(60)
             .HasColumnType("varchar(60)")
            .IsRequired();

              builder.Property(x => x.Cost)
                .HasColumnName("Cost")
                .HasColumnType("money")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
