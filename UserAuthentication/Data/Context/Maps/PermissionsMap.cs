using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Data.Context.Maps
{
    public class PermissionsMap : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.PermissionId);
            builder.Property(u => u.PermissionId).HasColumnName("permission_id");

            builder.Property(u => u.PermissionName)
                   .HasColumnName("permission_id")
                   .HasColumnType("varchar(50)")
                   .HasMaxLength(50)
                   .IsRequired(true);
        }
    }
}
