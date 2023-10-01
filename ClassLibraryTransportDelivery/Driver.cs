using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryTransportDelivery
{
    public class Driver : IValidatable
    {
        private string _FirstName;
        private string _LastName;
        private string _MiddleName;
        private int _Experience;

        public string FirstName
        {
            get => _FirstName;
            set => _FirstName = value;
        } 

        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }

        public string MiddleName
        {
            get => _MiddleName;
            set => _MiddleName = value;
        }

        public int Experience
        {
            get => _Experience;
            set => _Experience = value;
        }

        public bool isValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_FirstName)) return false;
                if (string.IsNullOrWhiteSpace(_LastName)) return false;
                if (string.IsNullOrWhiteSpace(_MiddleName)) return false;
                if (_Experience <= 0) return false;
                return true;
            }
        }

        public Driver() { }
        public Driver(string firstName, string lastName, string middleName, int experience)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Experience = experience;
        }

        public override string ToString()
        {
            return
                $"Фамилия: {_LastName}\nИмя: {_FirstName}\nОтчество: {_MiddleName}\nСтаж: {_Experience}\n";
        }
    }
}
