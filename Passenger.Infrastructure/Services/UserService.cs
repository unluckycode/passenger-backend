using System;
using AutoMapper;
using Passenger.Core.Domains;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDTO Get(string email)
        {
            var user = _userRepository.Get(email);

            return _mapper.Map<User,UserDTO>(user);
        }

        public void Register(string email, string username, string password)
        {
            var user = _userRepository.Get(email);
            if (user != null)
            {
                throw new Exception($"User with '{email}' already exists.");
            }
            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, password,salt,username);
            
            _userRepository.Add(user);
        }
    }
}