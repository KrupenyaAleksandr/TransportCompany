using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassLibraryTransportDelivery
{
    /// <summary>
    /// Транспортная компания
    /// </summary>
    public class TransportCompany
    {
        /// <summary>
        /// Словарь маршрутов
        /// </summary>
        public static Dictionary<int, Route> Routes { get; } = new Dictionary<int, Route>();
        /// <summary>
        /// Словарь водителей
        /// </summary>
        public static Dictionary<int, Driver> Drivers { get; } = new Dictionary<int, Driver>();
        /// <summary>
        /// Список завершённых работ
        /// </summary>
        public static List<DoneWork> DoneWorks { get; } = new List<DoneWork>();
    }
}
