using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Exceptions
{
    public sealed class HkeyServerErrorException : XhhCSBaseException
    {
        public HkeyServerErrorException()
        {
        }

        public HkeyServerErrorException(string? message) : base(message)
        {
        }

        public HkeyServerErrorException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }

        public HkeyServerErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
