using System;
using System.Collections.Generic;
using System.Linq;
using Passenger.Core.Domains;
using Passenger.Core.Repositories;

namespace Passenger.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        static ISet<User> _users = new HashSet<User>()
        {
            new User("user1@email.com", "secret", "salt", "user1"),
            new User("user2@email.com", "secret", "salt", "user2"),
            new User("user3@email.com", "secret", "salt", "user3")
        };
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid Id)
            => _users.Single(x => x.Id == Id);

        public User Get(string email)
            => _users.Single(x => x.Email == email.ToLowerInvariant());

        public IEnumerable<User> GetAll()
            => _users;

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}