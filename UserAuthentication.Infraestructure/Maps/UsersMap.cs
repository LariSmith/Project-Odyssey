using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserAuthentication.Domain.Entities;
using UserAuthentication.Domain.ValuesObjects;

namespace UserAuthentication.Presentation.Maps
{
    public class UsersMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email).HasConversion(
                Email => Email.Address,
                value => new Email(value));

            builder.Property(u => u.Username).HasConversion(
                Username => Username.Value,
                value => new Username(value));
        }
    }
}
