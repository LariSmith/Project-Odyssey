using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Domain.Entities
{
    public class Role
    {
        [Key]
        public Guid Id { get; private set; }

        public string RoleName { get; private set; }

        public ICollection<UserRoles> UserRoles { get; private set; } = new List<UserRoles>();

        public Role(string roleName) 
        {
            Id = Guid.NewGuid();
            RoleName = roleName;
        }
    }
}
