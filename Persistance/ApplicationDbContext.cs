using GlobalOutsourcingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalOutsourcingServices.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
    }
}
