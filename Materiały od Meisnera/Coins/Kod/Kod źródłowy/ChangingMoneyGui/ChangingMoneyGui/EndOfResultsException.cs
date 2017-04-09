using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ChangingMoneyGui
{
    [Serializable]
    public class EndOfResultsException : Exception
    {
        public EndOfResultsException()
        {
        }

        public EndOfResultsException(string message) : base(message)
        {
        }

        public EndOfResultsException(string message, Exception inner) : base(message, inner)
        {
        }

        protected EndOfResultsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
