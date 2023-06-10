using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Data.Context.Maps
{
    public class RolesMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
        }
    }
}
