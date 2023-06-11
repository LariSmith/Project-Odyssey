namespace UserAuthentication.Domain.ValuesObjects
{
    public class Username
    {
        const int MaxUsernameLength = 20;

        public string Value { get; }

        public Username(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Username cannot be empty or whitespace.");
            if (value.Length > 15)
                throw new ArgumentException($"Username cannot exceed {MaxUsernameLength} characters.");

            Value = value;
        }
    }
}
