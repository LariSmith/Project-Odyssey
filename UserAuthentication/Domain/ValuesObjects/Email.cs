using System.Net.Mail;
using System.Text.RegularExpressions;

namespace UserAuthentication.Domain.ValuesObjects
{
    public class Email
    {
        public string Address { get; }

        public Email(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentException("Email cannot be empty or whitespace.");
            if (!IsValidFormat(address))
                throw new ArgumentException("Invalid email format");

            Address = address;
        }

        private bool IsValidFormat(string address)
        {
            var valid = true;

            try { var emailAddress = new MailAddress(address); }
            catch { valid = false; }

            return valid;
        }
        
    }
}
