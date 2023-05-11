using System;
using Microsoft.EntityFrameworkCore;

namespace UserAuthentication.Data.Context
{
    public class UserAuthenticationContext : DbContext
    {
        public UserAuthenticationContext(DbContextOptions<UserAuthenticationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
