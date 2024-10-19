using BodegApp.Data.Entities;
using BodegApp.Models.DTOs;
using Data.Repository.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace BodegApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] AddUserDTO userDto)
        {
            try
            {
                int newUserId = _userServices.CreateUser(userDto);
                return Ok($"The User Id: {newUserId} has created succesfully.");
            }
            catch (Exception)
            {
                return BadRequest($"A user with the username {userDto.Username.ToUpper()} already exists and can't store duplicates");
            }
        }

    }
}
