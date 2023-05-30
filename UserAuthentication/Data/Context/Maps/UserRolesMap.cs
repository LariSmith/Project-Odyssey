using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Data.Context.Maps
{
    public class UserRolesMap : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.ToTable("UserRoles");

            builder.Property(x => x.UserId)
                   .HasColumnName("user_id")
                   .IsRequired();

            builder.Property(x => x.RoleId)
                   .HasColumnName("role_id")
                   .IsRequired();
        }
    }
}
