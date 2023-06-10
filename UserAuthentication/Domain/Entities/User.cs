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
         
        private readonly HashSet<UserRoles> _roles = new HashSet<UserRoles>();

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

        public void Add(Role role)
        {
            var userRoles = new UserRoles(Guid.NewGuid(), role.Id, Id);
            _roles.Add(userRoles);
            role.UserRoles.Add(userRoles);
        }
    }
}