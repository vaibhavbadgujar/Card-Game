using System.Runtime.Serialization;

namespace CG.BusinessLogic
{
    [Serializable]
    internal class MoreThenSixPlayerNotAllowException : Exception
    {
        public MoreThenSixPlayerNotAllowException()
        {
        }

        public MoreThenSixPlayerNotAllowException(string? message) : base(message)
        {
        }

        public MoreThenSixPlayerNotAllowException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MoreThenSixPlayerNotAllowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}