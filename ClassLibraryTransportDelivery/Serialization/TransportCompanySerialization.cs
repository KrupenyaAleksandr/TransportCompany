using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ClassLibraryTransportDelivery.Serialization
{
    [Serializable]
    public class TransportCompanySerialization
    {
        public List<Route> Routes { get; set; } = new List<Route>();
        public List<Driver> Drivers { get; set; } = new List<Driver>();
        public List<DoneWorkSerialization> DoneWorks { get; set; } = new List<DoneWorkSerialization>();
        public static void Save(string fileName, SerializeType serializeType)
        {
            var transportCompanySerializable = new TransportCompanySerialization();
            var transportCompany = TransportCompany.Instance;
            foreach(var route in transportCompany.Routes)
            {
                transportCompanySerializable.Routes.Add(route);
            }
            foreach(var driver in transportCompany.Drivers)
            {
                transportCompanySerializable.Drivers.Add(driver); 
            }
            foreach(var doneWork in transportCompany.DoneWorks)
            {
                transportCompanySerializable.DoneWorks.Add(new DoneWorkSerialization
                {
                    RouteId = doneWork.Route.RouteId,
                    DriverId = doneWork.Driver.DriverId,
                    StardDate = doneWork.StartDate,
                    EndDate = doneWork.EndDate
                });
            }
            switch (serializeType)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(TransportCompanySerialization));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, transportCompanySerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, transportCompanySerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite)) // мб другой мод надо
                    {
                        formatter.Serialize(binaryFileStream, transportCompanySerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(serializeType), serializeType, null);
            }
        }
        public static void Load(string fileName, SerializeType type)
        {
            TransportCompanySerialization transportCompanySerializable = new TransportCompanySerialization();
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(TransportCompanySerialization));
                    using (StreamReader streamReader = new StreamReader(fileName))
                    {
                        transportCompanySerializable = (TransportCompanySerialization)xmlSerializer.Deserialize(streamReader);
                    }
                    break;
                case SerializeType.JSON:
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    using (StreamReader jsonStreamReader = File.OpenText(fileName))
                    {
                        transportCompanySerializable = (TransportCompanySerialization)jsonSerializer.Deserialize(jsonStreamReader, typeof(TransportCompanySerialization));
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.Open))
                    {
                        transportCompanySerializable = (TransportCompanySerialization)formatter.Deserialize(binaryFileStream);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var transportCompany = TransportCompany.Instance;
            var transportCompanyRoutes = transportCompany.Routes.ToList();
            var transportCompanyDrivers = transportCompany.Drivers.ToList();
            var transportCompanyDoneWorks = transportCompany.DoneWorks.ToList();
            foreach (var _route in transportCompanyRoutes)
            {
                transportCompany.RemoveRoute(_route.RouteId);
            }
            foreach (var _driver in transportCompanyDrivers)
            {
                transportCompany.RemoveDriver(_driver.DriverId);
            }
            foreach (var _doneWork in transportCompanyDoneWorks)
            {
                transportCompany.RemoveDoneWork(_doneWork);
            }
            var routes = new Dictionary<int, Route>();
            var drivers = new Dictionary<int, Driver>();
            int maxRouteId = 0;
            int maxDriverId = 0;
            foreach (var route in transportCompanySerializable.Routes)
            {
                if (route.RouteId > maxRouteId) maxRouteId = route.RouteId;
                routes.Add(route.RouteId, route);
                transportCompany.AddRoute(route);
            }
            foreach (var driver in transportCompanySerializable.Drivers)
            {
                if (driver.DriverId > maxDriverId) maxDriverId = driver.DriverId;
                drivers.Add(driver.DriverId, driver);
                transportCompany.AddDriver(driver);
            }
            foreach (var doneWork in transportCompanySerializable.DoneWorks)
            {
                transportCompany.AddDoneWork(new DoneWork
                {
                    Route = routes[doneWork.RouteId],
                    Driver = drivers[doneWork.DriverId],
                    StartDate = doneWork.StardDate,
                    EndDate = doneWork.EndDate
                });
            }
            Route.NewRouteId = maxRouteId;
            Driver.NewDriverId = maxDriverId;
        }
    }
}
