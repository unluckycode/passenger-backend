namespace Passenger.Core.Domains
{
    public class PassengerNode
    {
        public Node Node { get; set; }
        public Passenger Passenger { get; set; }

        protected PassengerNode() { }

        public PassengerNode(Node node, Passenger passenger)
        {
            Node = node;
            Passenger = passenger;
        }
    }
}