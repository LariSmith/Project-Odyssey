using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Domain.Entities
{
    public class Roles
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string RoleName { get; set; }

        // Relationship 
        public virtual ICollection<UserRoles> Users { get; set; }
    }
}
