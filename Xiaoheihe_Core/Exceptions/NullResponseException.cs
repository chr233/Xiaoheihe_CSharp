using System.Runtime.Serialization;

namespace Xiaoheihe_Core.Exceptions
{
    /// <summary>
    /// 空响应错误
    /// </summary>
    public sealed class NullResponseException : XhhBaseException
    {
        public NullResponseException()
        {
        }

        public NullResponseException(string? message) : base(message)
        {
        }

        public NullResponseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public NullResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
