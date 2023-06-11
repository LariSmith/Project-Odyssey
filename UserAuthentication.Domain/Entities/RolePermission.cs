using UserAuthentication.Domain.Primitives;

namespace UserAuthentication.Domain.Entities
{
    public class RolePermission : BaseEntity
    {
        private Guid RoleId { get; set; }
        public Role Role { get; private set; }


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
