using BodegApp.Data.Entities;
using BodegApp.Models.DTOs;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserServices
    {
        User? AuthUser(CredentialsDto credentialsDTO);
        int AddUser(AddUserDTO addUserDTO);
    }
}
