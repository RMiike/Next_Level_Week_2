using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proffy.Core.Entities;

namespace Proffy.Data.Configurations
{
    public class ClassScheduleMaps : IEntityTypeConfiguration<ClassSchedule>
    {
        public void Configure(EntityTypeBuilder<ClassSchedule> builder)
        {
            builder.ToTable("ClassSchedule");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
              .HasColumnName("Id")
              .IsRequired();


            builder.Property(x => x.WeekDay)
            .HasColumnName("WeekDay")
             .HasColumnType("int")
            .IsRequired();

            builder.Property(x => x.From)
           .HasColumnName("From")
            .HasColumnType("int")
           .IsRequired();

            builder.Property(x => x.To)
           .HasColumnName("To")
            .HasColumnType("int")
           .IsRequired();

            builder.Property(x => x.ClassId)
           .HasColumnName("ClassId")
            .HasColumnType("int")
           .IsRequired();

            builder.HasOne(x => x.Class)
              .WithMany(x => x.ClassSchedules)
              .HasForeignKey(x => x.ClassId)
              .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
