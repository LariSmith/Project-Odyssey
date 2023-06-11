using UserAuthentication.Domain.Primitives;

namespace UserAuthentication.Domain.Entities
{
    public class Permission : BaseEntity
    {
        public string PermissionName { get; private set; }

        public ICollection<RolePermission> RolePermissions { get; internal set; } = new List<RolePermission>();

        public Permission(Guid id, string permissionName)
        {
            Id = id;
            PermissionName = permissionName;
        }

    }
}
