using System;
using System.Collections.Generic;
using Passenger.Core.Domains;

namespace Passenger.Infrastructure.DTO
{
    public class DriverDTO
    {
        public Guid UserGuidId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Route { get; protected set; }
        public IEnumerable<DailyRoute> DailyRoutes { get; protected set; }

    }
}