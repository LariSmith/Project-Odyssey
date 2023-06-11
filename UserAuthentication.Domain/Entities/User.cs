using UserAuthentication.Domain.Primitives;
using UserAuthentication.Domain.ValuesObjects;

namespace UserAuthentication.Domain.Entities
{
    public class User : BaseEntity
    {
        public Username Username { get; private set; }

        public Email Email { get; private set; }

        public string PasswordHash { get; private set; }

        public string Name { get; private set; }

        public DateTime CreateAt { get; private set; }

        public DateTime UpdateAt { get; private set; }

        public IReadOnlyCollection<UserRole> Roles => _roles;
        private readonly HashSet<UserRole> _roles = new HashSet<UserRole>();

        private RefreshToken? _refreshToken { get; set; }

        private User(Username username, Email email, string passwordHash, string name) 
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Name = name;
            CreateAt = DateTime.UtcNow;
            UpdateAt = DateTime.UtcNow;
        }

        public static User Create(Username username, Email email, string passwordHash, string name)
        {            
            return new User(username, email, passwordHash, name);
        }

        public void Add(Role role)
        {
            var userRoles = new UserRole(Guid.NewGuid(), role, this);
            _roles.Add(userRoles);
            role.UserRoles.Add(userRoles);
        } 

        public void Remove(Role role)
        {

        }

        public RefreshToken GenerateRefreshToken(string token, DateTime expirationTime)
        {
            var refreshToken = new RefreshToken(Guid.NewGuid(), this, token, expirationTime);
            _refreshToken = refreshToken;
            return refreshToken;
        }

        public RefreshToken? GetRefreshToken()
        {
            if (_refreshToken == null)
                return null;

            return _refreshToken;
        }

        public void CheckRefreshToken()
        {

        }

    }
}