using System.Runtime.Serialization;

namespace Xiaoheihe_Core.Exceptions
{
    /// <summary>
    /// 账号信息错误
    /// </summary>
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
