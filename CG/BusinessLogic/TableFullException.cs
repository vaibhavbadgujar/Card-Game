using System.Runtime.Serialization;

namespace CG.BusinessLogic
{
    [Serializable]
    internal class TableFullException : Exception
    {
        public TableFullException()
        {
        }

        public TableFullException(string? message) : base(message)
        {
        }

        public TableFullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TableFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}