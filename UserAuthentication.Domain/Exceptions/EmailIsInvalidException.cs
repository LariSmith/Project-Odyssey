using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Domain.Exceptions
{
    public sealed class EmailIsInvalidException : DomainException
    {
        public EmailIsInvalidException(string message) : base(message)
        {
        }
    }
}
