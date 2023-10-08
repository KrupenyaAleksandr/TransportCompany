using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery.Exception
{
    [Serializable]
    public class InvalidDoneWorkException : System.Exception
    {
        public InvalidDoneWorkException() { }
        public InvalidDoneWorkException(string message) : base(message) { }
        public InvalidDoneWorkException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidDoneWorkException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
