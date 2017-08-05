using System;

namespace Passenger.Core.Domains
{
    public class Route
    {
        public Guid Id { get; protected set; }
        public Node StartNode { get; protected set; }
        public Node EndNode { get; protected set; }

        protected Route() { }

        public Route(Guid id, Node startNode, Node endNode)
        {
            Id = id;
            StartNode = startNode;
            EndNode = endNode;
        }
    }
}