using System;
using System.Collections.Generic;

namespace Passenger.Core.Domains
{
    public class Passenger
    {
        public Guid Id { get; protected set; }
        public Guid UserGuidId { get; protected set; }
        public Node Address { get; protected set; }

        protected Passenger() { }
        public Passenger(Guid id, Guid userGuidId, Node addresss)
        {
            Id = id;
            UserGuidId = userGuidId;
            Address = addresss;
        }
    }
}