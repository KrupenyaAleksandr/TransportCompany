using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibraryTransportDelivery.Exception
{
    [Serializable]
    public class InvalidRouteException : System.Exception
    {
        public InvalidRouteException() { }
        public InvalidRouteException(string message) : base(message) { }
        public InvalidRouteException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidRouteException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}