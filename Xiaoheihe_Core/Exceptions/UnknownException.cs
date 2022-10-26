using System.Runtime.Serialization;

namespace Xiaoheihe_Core.Exceptions
{
    /// <summary>
    /// 未知错误
    /// </summary>
    public sealed class UnknownException : XhhBaseException
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
