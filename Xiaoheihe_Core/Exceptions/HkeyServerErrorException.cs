using System.Runtime.Serialization;

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
