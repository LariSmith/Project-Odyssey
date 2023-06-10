using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Data.Context.Maps
{
    public class UsersMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("user_id");

            builder.Property(u => u.Username)
                   .HasColumnName("username")
                   .HasColumnType("varchar(50)")
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.Property(u => u.Name)
                   .HasColumnName("name")
                   .HasColumnType("varchar(255)")
                   .HasMaxLength(255)
                   .IsRequired(true);

            builder.Property(u => u.Email)
                   .HasColumnName("email")
                   .HasColumnType("varchar(255)")
                   .HasMaxLength(255)
                   .IsRequired(true);

            builder.Property(u => u.PasswordHash)
                   .HasColumnName("password_hash")
                   .HasColumnType("varchar(255)")
                   .HasMaxLength(255)
                   .IsRequired(true);

            builder.Property(u => u.CreateAt)
                   .HasColumnName("create_at")
                   .HasColumnType("datetime")
                   .IsRequired(true);

            builder.Property(u => u.UpdateAt)
                   .HasColumnName("update_at")
                   .HasColumnType("datetime")
                   .IsRequired(false);
            
        }
    }
}
