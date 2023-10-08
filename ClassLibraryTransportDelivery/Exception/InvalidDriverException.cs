using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery.Exception
{
    [Serializable]
    public class InvalidDriverException : System.Exception
    {
        public InvalidDriverException() { }
        public InvalidDriverException(string message) : base(message) { }
        public InvalidDriverException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidDriverException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}