using System.Runtime.Serialization;

namespace Xiaoheihe_Core.Exceptions
{
    public sealed class UnknownException : XhhCSBaseException
    {
        public UnknownException()
        {
        }

        public UnknownException(string? message) : base(message)
        {
        }

        public UnknownException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }

        public UnknownException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
