using System;
using System.Runtime.Serialization;

namespace ChangingMoneyGui
{
    [Serializable]
    public class NoResultException : Exception
    {
        public NoResultException()
        {
        }

        public NoResultException(string message) : base(message)
        {
        }

        public NoResultException(string message, Exception inner) : base(message, inner)
        {
        }

        protected NoResultException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}