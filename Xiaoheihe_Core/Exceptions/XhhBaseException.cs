using System.Runtime.Serialization;

namespace Xiaoheihe_Core.Exceptions
{
    /// <summary>
    /// XhhCS错误基类
    /// </summary>
    public class XhhBaseException : ApplicationException
    {
        public XhhBaseException()
        {
        }

        public XhhBaseException(string? message) : base(message)
        {
        }

        public XhhBaseException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }

        protected XhhBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
