using System.Net.Mail;
using System.Text.RegularExpressions;
using UserAuthentication.Domain.Exceptions;

namespace UserAuthentication.Domain.ValuesObjects
{
    public record Email
    {
        public string Address { get; }

        public Email(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new EmailIsNullOrWhitespaceException("Email cannot be empty or whitespace.");
            if (!MailAddress.TryCreate(address, out _))
                throw new EmailIsInvalidException("Invalid email");

            Address = address;
        }
        
    }
}
