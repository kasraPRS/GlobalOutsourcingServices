using MediatR;

namespace GlobalOutsourcingServices.Application.Queries.LoginUser
{
    public class LoginUserQuery: IRequest<string>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
