using UserAuthentication.Domain.Primitives;

namespace UserAuthentication.Domain.Entities
{
    public class UserRole : BaseEntity
    {
        private Guid RoleId { get; set; }
        public Role Role { get; private set; }

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
