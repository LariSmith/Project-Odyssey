using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Data.Context.Maps
{
    public class RolesMap : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("role_id");

            builder.Property(u => u.RoleName)
                   .HasColumnName("role_name")
                   .HasColumnType("varchar(50)")
                   .HasMaxLength(50)
                   .IsRequired(true);
        }
    }
}
