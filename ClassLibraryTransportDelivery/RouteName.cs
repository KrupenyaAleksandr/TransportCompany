using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransportDelivery
{
    public class RouteName
    {
        private string _From; // назвать нормально пункт отправления
        private string _To; //пункт прибытия 

        public string From
        {
            get => _From;
            set => _From = value;
        }

        public string To
        {
            get => _To;
            set => _To = value;
        }

        public RouteName()
        {
            _From = "";
            _To = "";
        }

        public RouteName(string from, string to)
        {
            _From = from;
            _To = to;
        }

        public override string ToString()
        {
            return
                $"{_From} - {_To}";
        }
    }
}
