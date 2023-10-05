using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryTransportDelivery
{
    /// <summary>
    /// Водитель
    /// </summary>
    public class Driver : IValidatable
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = "";
        
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = "";

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; } = "";

        /// <summary>
        /// Стаж
        /// </summary>
        public int Experience { get; set; } = 1;

        public bool isValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (Experience <= 0) return false;
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
                $"Фамилия: {LastName}\nИмя: {FirstName}\nОтчество: {MiddleName}\nСтаж: {Experience}\n";
        }
    }
}
