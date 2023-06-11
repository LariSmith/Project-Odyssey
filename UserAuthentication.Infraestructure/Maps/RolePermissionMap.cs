using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Presentation.Maps
{
    public class RolePermissionsMap : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
        }
    }
}
