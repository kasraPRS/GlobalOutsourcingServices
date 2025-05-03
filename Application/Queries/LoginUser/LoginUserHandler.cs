
using GlobalOutsourcingServices.Inferastructure;
using GlobalOutsourcingServices.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GlobalOutsourcingServices.Application.Queries.LoginUser
{
    public class LoginUserHandler : IRequestHandler<LoginUserQuery, string>
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtService _jwtService;

        public LoginUserHandler(ApplicationDbContext context, IJwtService jwtServicec)
        {
            _context = context;
            _jwtService = jwtServicec;
        }

        public async Task<string> Handle(LoginUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == request.Username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
                throw new UnauthorizedAccessException("USERNAME_OR_EMAIL_COULD_BE_WRONG");

            return _jwtService.GenerateToken(user);
        }
    }
}
