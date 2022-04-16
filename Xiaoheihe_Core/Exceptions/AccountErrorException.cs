using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Exceptions
{
    public sealed class AccountErrorException : XhhCSBaseException
    {
        public AccountErrorException()
        {
        }

        public AccountErrorException(string? message) : base(message)
        {
        }

        public AccountErrorException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }

        public AccountErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
