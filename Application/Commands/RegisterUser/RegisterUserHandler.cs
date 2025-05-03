
using GlobalOutsourcingServices.Domain.Entities;
using GlobalOutsourcingServices.Inferastructure;
using GlobalOutsourcingServices.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;



namespace GlobalOutsourcingServices.Application.Commands.RegisterUser
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, string>
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtService _jwtService;
        public RegisterUserHandler(ApplicationDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        public async Task<string> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var exists = await _context.Users.AnyAsync(u => u.Username == request.Username);
            if (exists) throw new Exception("USER_REGISTERED_BEFORE");

            var user = new User
            {
                Username = request.Username,
                Password = BCrypt.Net.BCrypt.HashPassword(request.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return _jwtService.GenerateToken(user);
        }
    }
}
