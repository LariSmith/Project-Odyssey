using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Domain.Entities
{
    public class Permission
    {
        [Key]
        public Guid Id { get; private set; }

        public string PermissionName { get; private set; }

        public ICollection<RolePermission> RolePermissions { get; private set; } = new List<RolePermission>();



    }
}
