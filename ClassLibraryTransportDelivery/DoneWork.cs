using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery
{
    public class DoneWork : IValidatable
    {
        private Route _Route;
        private Driver _Driver;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private double _Award;

        public Route Route
        {
            get => _Route;
            set => _Route = value;
        }
        public Driver Driver
        {
            get => _Driver;
            set => _Driver = value;
        }

        public DateTime StartDate
        {
            get => _StartDate; 
            set => _StartDate = value;
        }

        public DateTime EndDate
        {
            get => _EndDate; 
            set => _EndDate = value;
        }

        public double Award
        {
            get => _Award; 
            set => _Award = value;
        }
        public bool isValid {
            get
            {
                if (_Route == null) return false;
                if (_Driver == null) return false;
                if (_StartDate == null || _StartDate < DateTime.Now) return false;
                if (_EndDate == null || _EndDate < DateTime.Now) return false;
                if (_StartDate >= _EndDate) return false;
                if (_Award < 1) return false;
                return true;
            }
        }
        public DoneWork() { }

        public DoneWork(Route route, Driver driver, DateTime startDate, DateTime endDate, double award)
        { // как правильно обращаться, сразу к локальной переменной класса или через сеттер 
            _Route = route;
            _Driver = driver;
            _StartDate = startDate;
            _EndDate = endDate;
            _Award = award;
        }

        public override string ToString()
        { // как правильно обращаться, сразу к локальной переменной класса или через геттер 
            return
                $"Маршрут:\n\n{_Route}\nВодитель:\n\n{_Driver}\nДата: {_StartDate} - {_EndDate}\nПремия: {_Award}\n\n";
        }
    }
}
