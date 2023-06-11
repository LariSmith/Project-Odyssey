using UserAuthentication.Domain.Exceptions;

namespace UserAuthentication.Domain.ValuesObjects
{
    public class Username
    {
        const int MaxUsernameLength = 20;

        public string Value { get; }

        public Username(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new UsernameIsNullOrWhitespaceException("Username cannot be empty or whitespace.");
            if (value.Length > 15)
                throw new UsernameMaxLengthException($"Username cannot exceed {MaxUsernameLength} characters.");

            Value = value;
        }
    }
}
