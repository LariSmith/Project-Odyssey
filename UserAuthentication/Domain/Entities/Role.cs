using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Domain.Entities
{
    public class Role
    {
        [Key]
        public Guid Id { get; private set; }

        public string RoleName { get; private set; }

        public ICollection<UserRole> UserRoles { get; internal set; } = new List<UserRole>();

        private readonly HashSet<RolePermission> _permission = new HashSet<RolePermission>();

        public Role(string roleName) 
        {
            Id = Guid.NewGuid();
            RoleName = roleName;
        }

        private Role() 
        {}
        
        public void Add(Permission permission)
        {
            var role = new Role
            {
                Id = Id,
                RoleName = RoleName
            };

            var rolePermission = new RolePermission(Guid.NewGuid(), role, permission);
            permission.RolePermissions.Add(rolePermission);
            _permission.Add(rolePermission);
        }

        public void Remove(Permission permission)
        {

        }
    }
}
