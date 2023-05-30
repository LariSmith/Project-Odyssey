﻿using System;
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
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Maps.UsersMap());
            modelBuilder.ApplyConfiguration(new Maps.RolesMap());
            modelBuilder.ApplyConfiguration(new Maps.PermissionsMap());
            modelBuilder.ApplyConfiguration(new Maps.UserRolesMap());
        }

    }
}
