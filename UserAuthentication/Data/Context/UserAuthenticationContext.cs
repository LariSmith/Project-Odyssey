using System;
using Microsoft.EntityFrameworkCore;
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

        }

    }
}
