using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery
{
    /// <summary>
    /// Маршрут
    /// </summary>
    [Serializable]
    public class Route : IValidatable
    {
        /// <summary>
        /// id маршрута
        /// </summary>
        private static int _NewRouteId;

        /// <summary>
        /// новый id маршрута
        /// </summary>
        public static int NewRouteId
        {
            get
            {
                _NewRouteId++;
                return _NewRouteId;
            }
            set
            { 
                _NewRouteId = value; 
            }
        }

        public int RouteId { get; set; }

        /// <summary>
        /// Название маршрута
        /// </summary>
        public RouteName Name { get; set; } = new RouteName();

        /// <summary>
        /// Дистанция в километрах
        /// </summary>
        public int Distance { get; set; } = 1;

        /// <summary>
        /// Время в пути в днях
        /// </summary>
        public int TripTimeInDays { get; set; } = 1;

        /// <summary>
        /// Оплата
        /// </summary>
        public double Payment { get; set; } = 1;
        public bool isValid
        {
            get
            {
                if (Name == null || (Name.From == String.Empty || Name.To == String.Empty)) return false;
                if (Distance <= 0) return false;
                if (TripTimeInDays <= 0) return false;
                if (Payment <= 0) return false;
                return true;
            }
        }

        public Route() 
        {
            RouteId = NewRouteId;
        }

        public Route(RouteName name, int distance, int tripTimeInDays, double payment)
        {
            Name = name;
            Distance = distance;
            TripTimeInDays = tripTimeInDays;
            Payment = payment;
            RouteId = NewRouteId;
        }

        public override string ToString()
        {
            return
                //$"Название: {Name}\nДистанция: {Distance}\nВремя в пути: {TripTimeInDays}\nОплата: {Payment}\n";
                $"{Name}";
        }
    }
}
