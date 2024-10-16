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

        public int AddUser(AddUserDTO addUserDTO)
        {
            if (_userRepository.GetUsers().All(u => u.Username != addUserDTO.Username))
            {
                try
                {
                    int newUserId = _userRepository.CreateUser(
                        new User
                        {
                            Id = _userRepository.GetUsers().Max(x => x.Id) + 1,
                            Username = addUserDTO.Username,
                            Password = addUserDTO.Password
                        }
                        );
                    return newUserId;
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
