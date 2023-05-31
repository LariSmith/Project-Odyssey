using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthentication.Domain.Entities
{
    public class UserRoles
    {
        [Key]
        [Required]
        [ForeignKey("Users")]
        public int RoleId { get; set; }

        [Key]
        [Required]
        [ForeignKey("Roles")]
        public int UserId { get; set; }

        // Relationship 
        public virtual Roles Role { get; set; }
        public virtual Users User { get; set; }
    }
}
