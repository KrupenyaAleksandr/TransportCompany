﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery
{
    public class DoneWork : IValidatable
    {

        public Route Route { get; set; }
        public Driver Driver { get; set; }

        /// <summary>
        /// Дата отправки
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата возвращения
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Премия
        /// </summary>
        public double Award { get; set; }
        public bool isValid {
            get
            {
                if (Route == null) return false;
                if (Driver == null) return false;
                if (StartDate == null || StartDate < DateTime.Now) return false;
                if (EndDate == null || EndDate < DateTime.Now) return false;
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
