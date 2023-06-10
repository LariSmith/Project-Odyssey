using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthentication.Domain.Entities
{
    public class UserRoles
    {
        [Key]
        public Guid Id { get; private set; }

        [ForeignKey("Users")]
        public Guid RoleId { get; private set; }

        [ForeignKey("Roles")]
        public Guid UserId { get; private set; }

        internal UserRoles(Guid id, Guid roleId, Guid userId)
        {
            Id = id;
            RoleId = roleId;
            UserId = userId;
        }
    }
}
