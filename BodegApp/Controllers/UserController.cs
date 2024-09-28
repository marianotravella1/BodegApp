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
        UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpPost]
        public IActionResult AddUser([FromBody] AddUserDTO dto)
        {
            User newUser = new User()
            {
                Id = _userRepository.Users.Max(x => x.Id),
                Username = dto.Username,
                Password = dto.Password,
            };

            return Ok(dto);
        }
        
    }
}
