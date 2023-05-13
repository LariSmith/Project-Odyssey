using System;
using Microsoft.EntityFrameworkCore;
using UserAuthentication.Data.Context.Maps;
using UserAuthentication.Domain.Entities;

namespace UserAuthentication.Data.Context
{
    public class UserAuthenticationContext : DbContext
    {
        public UserAuthenticationContext(DbContextOptions<UserAuthenticationContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Maps.UsersMap());
        }

    }
}
