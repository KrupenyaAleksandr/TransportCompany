using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery
{
    public class Route : IValidatable
    {
        private RouteName _Name;
        private int _Distance;
        private int _TripTimeInDays;
        private double _Payment;

        public RouteName Name
        {
            get {
                if (_Name == null){
                    _Name = new RouteName();
                }
                return _Name;
            }
            set {
                _Name = value;
                    
            }
        }

        public int Distance
        {
            get => _Distance;
            set => _Distance = value;
/*            set
            {
                if (value < 1) { // наверно надо переделать под диалоговое окно
                    Console.WriteLine("Дистанция должна быть больше нуля!\n");
                }
                else 
                    _Distance = value;
            }*/
        }

        public int TripTimeInDays
        {
            get => _TripTimeInDays;
            set => _TripTimeInDays = value;
/*            set
            {
                if (value < 1) { // наверно надо переделать под диалоговое окно
                    Console.WriteLine("Время в пути должно быть больше нуля!\n");
                }
                else
                    _TripTimeInDays = value;
            }*/
        }
        public double Payment
        {
            get => _Payment;
            set => _Payment = value;
/*            set
            {
                if (value < 1){
                    Console.WriteLine("Оплата должна быть больше нуля!\n");
                }
                else 
                    _Payment = value;
            }*/
        }
        public bool isValid
        {
            get
            {
                if (_Name == null) return false;
                if (_Distance <= 0) return false;
                if (_TripTimeInDays <= 0) return false;
                if (_Payment <= 0) return false;
                return true;
            }
        }

        public Route()
        {

        }

        public Route(RouteName name, int distance, int tripTimeInDays, double payment)
        {
            _Name = name;
            _Distance = distance;
            _TripTimeInDays = tripTimeInDays;
            _Payment = payment;
        }

        public override string ToString()
        {
            return
                $"Название: {_Name}\nДистанция: {_Distance}\nВремя в пути: {_TripTimeInDays}\nОплата: {_Payment}\n";
        }
    }
}
