using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery
{
    [Serializable]
    public class DoneWork : IValidatable
    {

        public Route Route { get; set; }
        public Driver Driver    { get; set; }

        /// <summary>
        /// Дата отправки
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата возвращения
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Премия
        /// </summary>
        public double Award { get; set; } = 1;
        public bool isValid {
            get
            {
                if (Route == null) return false;
                if (Driver == null) return false;
                if (StartDate == null) return false;
                if (EndDate == null) return false;
                if (StartDate >= EndDate) return false;
                if (Award < 1) return false;
                return true;
            }
        }
        public DoneWork() { }

        public DoneWork(Route route, Driver driver, DateTime startDate, DateTime endDate, double award)
        {
            Route = route;
            Driver = driver;
            StartDate = startDate;
            EndDate = endDate;
            Award = award;
        }

        public override string ToString()
        {
            return
                $"Маршрут:\n\n{Route}\nВодитель:\n\n{Driver}\nДата: {StartDate} - {EndDate}\nПремия: {Award}\n\n";
        }
    }
}
