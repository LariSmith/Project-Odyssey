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

            builder.HasKey(u => u.Id);
        }
    }
}
