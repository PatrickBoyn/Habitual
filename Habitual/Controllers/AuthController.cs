using System.Threading.Tasks;
using Habitual.Data;
using Habitual.DTOs;
using Habitual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Habitual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDto registerUserDto)
        {
            
            registerUserDto.Username = registerUserDto.Username.ToLower();

            if (await _repo.UserExists(registerUserDto.Username))
                return BadRequest("Username already exists.");

            var createUser = new User
            {
                Username = registerUserDto.Username
            };

            var userAfterCreation = await _repo.Register(createUser, registerUserDto.Password);

            return StatusCode(201);
        }
    }
}