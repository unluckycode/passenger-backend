namespace Passenger.Infrastructure.Commands.Users
{
    public class CreateUser : ICommmand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}