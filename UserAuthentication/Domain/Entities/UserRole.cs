using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthentication.Domain.Entities
{
    public class UserRole
    {
        [Key]
        public Guid Id { get; private set; }

        [ForeignKey("User")]
        private Guid RoleId { get; set; }
        public Role Role { get; private set; }

        [ForeignKey("Role")]
        private Guid UserId { get; set; }
        public User User { get; private set; }

        internal UserRole(Guid id, Role role, User user)
        {
            Id = id;
            Role = role;
            RoleId = role.Id;
            UserId = user.Id;
            User = user;
        }
    }
}
