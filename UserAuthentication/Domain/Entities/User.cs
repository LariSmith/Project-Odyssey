using System.ComponentModel.DataAnnotations;
using UserAuthentication.Domain.ValuesObjects;

namespace UserAuthentication.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; private set; }

        public Username Username { get; private set; }

        public Email Email { get; private set; }

        public string PasswordHash { get; private set; }

        public string Name { get; private set; }

        public DateTime CreateAt { get; private set; }

        public DateTime UpdateAt { get; private set; }
         
        private readonly HashSet<UserRole> _roles = new HashSet<UserRole>();

        public User(Username username, Email email, string passwordHash, string name)
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Name = name;
            CreateAt = DateTime.UtcNow;
            UpdateAt = DateTime.UtcNow;
        }

        private User() { }

        public void Add(Role role)
        {
            var user = new User
            {
                Id = Id,
                Username = Username,
                Email = Email,
                PasswordHash = PasswordHash,
                Name = Name,
                CreateAt = CreateAt,
                UpdateAt = UpdateAt
            };

            var userRoles = new UserRole(Guid.NewGuid(), role, user);
            _roles.Add(userRoles);
            role.UserRoles.Add(userRoles);
        }
    }
}