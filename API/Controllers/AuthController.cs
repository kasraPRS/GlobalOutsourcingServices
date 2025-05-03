using GlobalOutsourcingServices.Application.Commands.RegisterUser;
using GlobalOutsourcingServices.Application.Queries.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GlobalOutsourcingServices.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserCommand command)
        {
            var token = await _mediator.Send(command);
            return Ok(new { Token = token });
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserQuery query)
        {
            var token = await _mediator?.Send(query);
            return Ok(new { Token = token });
        }
    }
}
