using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ClassLibraryTransportDelivery.Exception;

namespace ClassLibraryTransportDelivery
{
    /// <summary>
    /// Транспортная компания
    /// </summary>
    [Serializable]
    public class TransportCompany
    {
        private static TransportCompany _instance;
        /// <summary>
        /// Единственный экземпляр класса
        /// </summary>
        public static TransportCompany Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransportCompany();
                }
                return _instance;
            }
        }
        private TransportCompany()
        {

        }
        /// <summary>
        /// Словарь маршрутов
        /// </summary>
        private Dictionary<int, Route> _routes { get; } = new Dictionary<int, Route>();
        /// <summary>
        /// Добавление маршрута
        /// </summary>
        /// <param name="route"></param>
        /// <exception cref="InvalidRouteException"></exception>
        public void AddRoute(Route route)
        {
            if (!route.isValid)
            {
                throw new InvalidRouteException("Информация о маршруте заполнена некорректно");
            }
            try
            {
                _routes.Add(route.RouteId, route);
                RouteAdded?.Invoke(route, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidRouteException("При добавлении клиента произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удаление маршрута
        /// </summary>
        /// <param name="routeId"></param>
        public void RemoveRoute(int routeId)
        {
            _routes.Remove(routeId);
            RouteRemoved?.Invoke(routeId, EventArgs.Empty);
            var doneWorksWithRoute = DoneWorks.Where(s => s.Route.RouteId == routeId).ToList();
            for (int i = 0; i < doneWorksWithRoute.Count; ++i)
            {
                RemoveDoneWork(doneWorksWithRoute[i]);
            }
        }
        /// <summary>
        /// Словарь водителей
        /// </summary>
        private Dictionary<int, Driver> _drivers { get; } = new Dictionary<int, Driver>();
        /// <summary>
        /// Добавление водителя по id
        /// </summary>
        /// <param name="driver"></param>
        /// <exception cref="InvalidDriverException"></exception>
        public void AddDriver(Driver driver)
        {
            if (!driver.isValid)
            {
                throw new InvalidDriverException("Информация о водителе заполнена некорректно");
            }
            try
            {
                _drivers.Add(driver.DriverId, driver);
                DriverAdded?.Invoke(driver, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidDriverException("При добавлении водителя произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удаление водителя по id
        /// </summary>
        /// <param name="driverId"></param>
        public void RemoveDriver(int driverId)
        {
            _drivers.Remove(driverId);
            DriverRemoved?.Invoke(driverId, EventArgs.Empty);
            var doneWorksWithDriver = DoneWorks.Where(s => s.Driver.DriverId == driverId).ToList();
            for (int i = 0; i < doneWorksWithDriver.Count; ++i)
            {
                RemoveDoneWork(doneWorksWithDriver[i]);
            }
        }
        /// <summary>
        /// Список выполненных заказов
        /// </summary>
        private static List<DoneWork> _doneWorks { get; } = new List<DoneWork>();
        /// <summary>
        /// Добавление выполненного заказа
        /// </summary>
        /// <param name="doneWork"></param>
        /// <exception cref="InvalidDoneWorkException"></exception>
        public void AddDoneWork(DoneWork doneWork)
        {
            if (!doneWork.isValid)
            {
                throw new InvalidDoneWorkException("Информация о выполненном заказе заполнена некорректно");
            }
            try
            {
                _doneWorks.Add(doneWork);
                DoneWorkAdded?.Invoke(doneWork, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidDoneWorkException("При добавлении выполненного заказа произошла ошибка", exception);
            }
        }
        public void RemoveDoneWork(DoneWork doneWork)
        {
            _doneWorks.Remove(doneWork);
            DoneWorkRemoved?.Invoke(doneWork, EventArgs.Empty);
        }
        /// <summary>
        /// Коллекция маршрутов
        /// </summary>
        public IEnumerable<Route> Routes
        {
            get { return _routes.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Коллекция водителей
        /// </summary>
        public IEnumerable<Driver> Drivers
        {
            get { return _drivers.Values.AsEnumerable();}
        }
        public IEnumerable<DoneWork> DoneWorks
        {
            get { return _doneWorks; }
        }

        public event EventHandler RouteAdded;
        public event EventHandler DriverAdded;
        public event EventHandler DoneWorkAdded;
        public event EventHandler RouteRemoved;
        public event EventHandler DriverRemoved;
        public event EventHandler DoneWorkRemoved;
    }
}
