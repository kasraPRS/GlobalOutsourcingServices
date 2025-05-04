using MediatR;

namespace GlobalOutsourcingServices.Services.LoginAndRegister.Application.Queries.LoginUser
{
    public class LoginUserQuery: IRequest<string>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
