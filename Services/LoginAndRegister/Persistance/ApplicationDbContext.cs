using GlobalOutsourcingServices.Services.LoginAndRegister.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalOutsourcingServices.Services.LoginAndRegister.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
    }
}
