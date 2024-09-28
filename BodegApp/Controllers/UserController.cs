using BodegApp.DTOs;
using BodegApp.Entities;
using BodegApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BodegApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpPost]
        public IActionResult AddUser([FromBody] AddUserDTO dto)
        {
            User newUser = new User()
            {
                Id = _userRepository.Users.Max(x => x.Id)+1,
                Username = dto.Username,
                Password = dto.Password,
            };

            _userRepository.Users.Add(newUser);

            return Ok(newUser);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userRepository.Users);
        }
        
    }
}
