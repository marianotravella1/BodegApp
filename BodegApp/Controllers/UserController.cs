using BodegApp.Data.Entities;
using BodegApp.Models.DTOs;
using Data.Repository.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public IActionResult CreateUser([FromBody] AddUserDTO userDto)
        {
            try
            {
                _userServices.Create(userDto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
