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
    [Serializable]
    public class Driver : IValidatable
    {
        /// <summary>
        /// id нового водителя
        /// </summary>
        private static int _NewDriverId;

        public static int NewDriverId
        {
            get
            {
                _NewDriverId++;
                return _NewDriverId;
            }
            set 
            { 
                _NewDriverId = value; 
            }
        }

        /// <summary>
        /// id водителя
        /// </summary>
        public int DriverId { get; set; }

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

        public Driver() 
        {
            DriverId = NewDriverId;
        }
        public Driver(string firstName, string lastName, string middleName, int experience)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Experience = experience;
            DriverId = NewDriverId;
        }

        public override string ToString()
        {
            return
                //$"Фамилия: {LastName}\n\rИмя: {FirstName}\n\rОтчество: {MiddleName}\n\rСтаж: {Experience}\n";
                $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
