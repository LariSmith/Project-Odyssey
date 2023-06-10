namespace UserAuthentication.Domain.ValuesObjects
{
    public class Username
    {
        public string Value { get; }

        private Username(string value)
        {
            Value = value;
        }

        public static Username Create(string value)
        {
            const int MaxUsernameLength = 20;

            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Username cannot be empty or whitespace.");
            if (value.Length > 15)
                throw new ArgumentException($"Username cannot exceed {MaxUsernameLength} characters.");

            return new Username(value);
        }
    }
}
