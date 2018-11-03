using System.Threading.Tasks;
using Habitual.Data;
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
        public async Task<IActionResult> Register(string username, string password)
        {
            //TODO validate request
            username = username.ToLower();

            if (await _repo.UserExists(username))
                return BadRequest("Username already exists.");

            var createUser = new User
            {
                Username = username
            };

            var userAfterCreation = await _repo.Register(createUser, password);

            return StatusCode(201);
        }
    }
}