using GlobalOutsourcingServices.Services.Tasks.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalOutsourcingServices.Services.Tasks.Persistance
{
    public class TasksDbContext : DbContext
    {
 
            public DbSet<TaskModel> TaskModels { get; set; }

            public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options) { }
        
    }
}
