using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery
{
    [Serializable]
    public class RouteName
    {
        /// <summary>
        /// Пункт отправления
        /// </summary>
        public string From { get; set; } = "";

        /// <summary>
        /// Пункт прибытия
        /// </summary>
        public string To { get; set; } = "";

        public RouteName() { }

        public RouteName(string from, string to)
        {
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return
                $"{From} - {To}";
        }
    }
}
