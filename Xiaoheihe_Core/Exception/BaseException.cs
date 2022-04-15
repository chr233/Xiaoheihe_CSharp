using System.Runtime.Serialization;

namespace Xiaoheihe_CShape.Exception
{
    internal class BaseException : ApplicationException
    {
        public BaseException()
        {
        }

        public BaseException(string? message) : base(message)
        {
        }

        public BaseException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }

        protected BaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
