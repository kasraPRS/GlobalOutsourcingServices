using MediatR;

namespace GlobalOutsourcingServices.Services.LoginAndRegister.Application.Commands.RegisterUser
{
    public class RegisterUserCommand: IRequest<string>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
