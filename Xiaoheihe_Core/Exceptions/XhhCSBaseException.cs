using System.Runtime.Serialization;

namespace Xiaoheihe_Core.Exceptions
{
    /// <summary>
    /// XhhCS错误基类
    /// </summary>
    public class XhhCSBaseException : ApplicationException
    {
        public XhhCSBaseException()
        {
        }

        public XhhCSBaseException(string? message) : base(message)
        {
        }

        public XhhCSBaseException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }

        protected XhhCSBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
