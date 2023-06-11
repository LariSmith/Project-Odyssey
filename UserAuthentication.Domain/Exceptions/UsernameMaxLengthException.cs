using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Domain.Exceptions
{
    public sealed class UsernameMaxLengthException : DomainException
    {
        public UsernameMaxLengthException(string message) : base(message)
        {
        }
    }
}
