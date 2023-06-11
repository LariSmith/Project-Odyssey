using System;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Data.Context.Maps;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Presentation
{
    public class UserAuthenticationContext : DbContext
    {
        public UserAuthenticationContext(DbContextOptions<UserAuthenticationContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Maps.UsersMap());
            modelBuilder.ApplyConfiguration(new Maps.RolesMap());
            modelBuilder.ApplyConfiguration(new Maps.PermissionsMap());
            modelBuilder.ApplyConfiguration(new Maps.UserRolesMap());
            modelBuilder.ApplyConfiguration(new Maps.RolePermissionsMap());
            modelBuilder.ApplyConfiguration(new Maps.RefreshTokenMap());
        }

    }
}
