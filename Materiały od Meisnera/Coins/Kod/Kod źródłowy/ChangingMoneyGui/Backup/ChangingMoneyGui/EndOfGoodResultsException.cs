using System;
using System.Collections.Generic;
using System.Text;

namespace ChangingMoneyGui
{
    [global::System.Serializable]
    public class EndOfGoodResultsException : Exception
    {
        public EndOfGoodResultsException() { }
        public EndOfGoodResultsException(string message) : base(message) { }
        public EndOfGoodResultsException(string message, Exception inner) : base(message, inner) { }
        protected EndOfGoodResultsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
