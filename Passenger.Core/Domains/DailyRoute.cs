using System;
using System.Collections.Generic;

namespace Passenger.Core.Domains
{
    public class DailyRoute
    {
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public IEnumerable<PassengerNode> PassengerNodes { get; protected set; }

        public DailyRoute(Guid id, Route route, IEnumerable<PassengerNode> passengerNodes)
        {
            Id = id;
            Route = route;
            PassengerNodes = passengerNodes;
        }

    }
}