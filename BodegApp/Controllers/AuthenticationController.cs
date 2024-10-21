using BodegApp.Data.Entities;
using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BodegApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly IConfiguration _config;

        public AuthenticationController(IUserServices userServices, IConfiguration config)
        {
            _userServices = userServices;
            _config = config;
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] CredentialsDto credentialsDto)
        {
            User? user = _userServices.AuthUser(credentialsDto);

            if (user == null)
            {
                return Unauthorized();
            }

            SymmetricSecurityKey securityPassword = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"]!));
            SigningCredentials credentials = new SigningCredentials(securityPassword, SecurityAlgorithms.HmacSha256);

            List<Claim> claimsForToken = new List<Claim>()
            {
                new Claim("sub", user.Id.ToString()),
                new Claim("given_name", user.Username)
            };

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
              _config["Authentication:Issuer"],
              _config["Authentication:Audience"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddMinutes(int.Parse(_config["Authentication:MinToExpireJWT"]!)),
              credentials);


            return Ok(new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToken));
        }
    }
}
