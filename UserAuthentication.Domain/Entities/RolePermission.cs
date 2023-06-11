using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthentication.Domain.Entities
{
    public class RolePermission
    {
        [Key]
        public Guid Id { get; private set; }

        [ForeignKey("Role")]
        private Guid RoleId { get; set; }
        public Role Role { get; private set; }

        [ForeignKey("Permission")]
        private Guid PermissionId { get; set; }
        public Permission Permission { get; private set; }

        internal RolePermission(Guid id, Role role, Permission permission)
        {
            Id = id;
            Role = role;
            RoleId = role.Id;
            Permission = permission;
            PermissionId = permission.Id;
        }
    }
}
