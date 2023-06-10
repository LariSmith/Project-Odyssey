using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthentication.Domain.Entities
{
    public class RefreshToken
    {
        [Key]
        public Guid Id { get; private set; }

        [ForeignKey("User")]
        private Guid UserId { get; set; }
        public User User { get; private set; }

        public string Token { get; private set; }

        public DateTime ExpirationTime { get; private set; }

        public DateTime CreateAt { get; private set; }

        internal RefreshToken(Guid id,User user, string token, DateTime expirationTime) 
        { 
            Id = id;
            UserId = user.Id;
            User = user;
            Token = token;
            ExpirationTime = expirationTime;
            CreateAt = DateTime.Now;
        }
    }
}
