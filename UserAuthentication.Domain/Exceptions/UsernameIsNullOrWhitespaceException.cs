namespace UserAuthentication.Domain.Exceptions
{
    internal sealed class UsernameIsNullOrWhitespaceException : DomainException
    {
        public UsernameIsNullOrWhitespaceException(string message) : base(message)
        {
        }
    }
}
