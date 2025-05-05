using GlobalOutsourcingServices.Services.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalOutsourcingServices.Services.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
    }
}
