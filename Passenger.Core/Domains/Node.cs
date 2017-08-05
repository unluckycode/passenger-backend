namespace Passenger.Core.Domains
{
    public class Node
    {
        public string Address { get; protected set; }
        public double Longitude { get; protected set; }
        public double Latitude { get; protected set; }

        protected Node()
        {

        }

        public Node(string address, double longitude, double latitude)
        {
            Address = address;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}