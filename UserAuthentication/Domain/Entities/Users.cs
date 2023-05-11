using UserAuthentication.Domain.ValuesObjects;

namespace UserAuthentication.Domain.Entities
{
    public class Users
    {
        public int UserID { get; set; }
        public Username Username { get; set; }
        public Email Email { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
