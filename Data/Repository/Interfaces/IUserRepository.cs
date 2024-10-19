using BodegApp.Data.Entities;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        User? AuthUser(CredentialsDto credentialsDTO);
        List<User> GetUsers();
        void AddUser(User user);
    }
}
