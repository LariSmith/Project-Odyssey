using System.ComponentModel.DataAnnotations;
using UserAuthentication.Domain.ValuesObjects;

namespace UserAuthentication.Domain.Entities
{
    public class Users
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        [Required]
        public DateTime UpdateAt { get; set; }

        // Relationship 
        public virtual ICollection<UserRoles> Roles { get; set; }
    }
}
