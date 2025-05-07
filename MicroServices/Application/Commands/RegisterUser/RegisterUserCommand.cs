using MediatR;

namespace GlobalOutsourcingServices.Services.Application.Commands.RegisterUser
{
    public class RegisterUserCommand: IRequest<string>
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
