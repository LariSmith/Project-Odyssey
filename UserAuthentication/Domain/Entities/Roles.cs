namespace UserAuthentication.Domain.Entities
{
    public class Roles
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<UserRoles> Users { get; set; }
    }
}
