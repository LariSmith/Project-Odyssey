using System.Net.Mail;
using System.Text.RegularExpressions;

namespace UserAuthentication.Domain.ValuesObjects
{
    public record Email
    {
        public string Address { get; }

        public Email(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentException("Email cannot be empty or whitespace.");
            if (!MailAddress.TryCreate(address, out _))
                throw new ArgumentException("Invalid email");

            Address = address;
        }
        
    }
}
