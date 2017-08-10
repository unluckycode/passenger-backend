using System;
using System.Collections.Generic;

namespace Passenger.Core.Domains
{
    public class Driver
    {
        public Guid UserGuidId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Route { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

        protected Driver() { }
        public Driver(Guid userGuidId, Vehicle vehicle, IEnumerable<Route> route, IEnumerable<DailyRoute> dailyRoutes)
        {
            UserGuidId = userGuidId;
            Vehicle = vehicle;
            Route = route;
            DailyRoutes = dailyRoutes;
        }
    }
}