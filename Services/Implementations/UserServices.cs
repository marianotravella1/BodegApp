using BodegApp.Data.Entities;
using BodegApp.Models.DTOs;
using Common.Models;
using Data.Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Inplementations
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? AuthUser(CredentialsDto credentialsDto)
        {
            return _userRepository.AuthUser(credentialsDto);
        }

        public void Create(AddUserDTO addUserDTO)
        {
            User newUser = new User
            {
                Username = addUserDTO.Username,
                Password = addUserDTO.Password
            };

            _userRepository.AddUser(newUser);
        }
    }
}
