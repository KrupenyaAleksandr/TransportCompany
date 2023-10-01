using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTransportDelivery;

namespace Lab4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            Route _route = new Route(new RouteName("Брянск", "Москва"), 380, 1, 1000);
            Driver _driver = new Driver("Александр", "Крупеня", "Сергеевич", 3);
            DoneWork _doneWork = new DoneWork(_route, _driver, new DateTime(2023, 9, 29), new DateTime(2023, 10, 1), 1000);
            Console.WriteLine(_doneWork.ToString());
            Console.WriteLine("");
        }
    }
}
