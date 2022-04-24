using System.Runtime.Serialization;

namespace Xiaoheihe_Core.Exceptions
{
    /// <summary>
    /// Hkey Server响应错误
    /// </summary>
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
