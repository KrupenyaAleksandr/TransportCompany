using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery.Serialization
{
    [Serializable]
    public class DoneWorkSerialization
    {
        public int RouteId { get; set; }
        public int DriverId { get; set; }
        /// <summary>
        /// Дата начала заказа
        /// </summary>
        public DateTime StardDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата выполнения заказа
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
