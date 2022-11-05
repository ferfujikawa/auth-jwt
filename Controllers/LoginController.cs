using auth_jwt.Entities;
using auth_jwt.Repositories;
using auth_jwt.Services;
using Microsoft.AspNetCore.Mvc;

namespace auth_jwt.Controllers
{
    [ApiController]
    [Route("v1/login")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Authenticate(
            [FromServices] UserRepository userRepository,
            [FromServices] TokenService tokenService,
            [FromBody] User model)
        {
            var user = userRepository.GetUser(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos"});

            var token = tokenService.GenerateToken(user);

            return new OkObjectResult(new {
                username = user.Username,
                token = token
            });
        }
    }
}
