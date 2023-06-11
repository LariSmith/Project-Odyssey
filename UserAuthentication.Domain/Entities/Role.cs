using UserAuthentication.Domain.Primitives;

namespace UserAuthentication.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName { get; private set; }

        public ICollection<UserRole> UserRoles { get; internal set; } = new List<UserRole>();

        private readonly HashSet<RolePermission> _permission = new HashSet<RolePermission>();

        private Role(string roleName) 
        {
            Id = Guid.NewGuid();
            RoleName = roleName;
        }

        public static Role Create(string roleName)
        {
            return new Role(roleName);
        }
        
        public void Add(Permission permission)
        {
            var rolePermission = new RolePermission(Guid.NewGuid(), this, permission);
            permission.RolePermissions.Add(rolePermission);
            _permission.Add(rolePermission);
        }

        public void Remove(Permission permission)
        {

        }
    }
}
