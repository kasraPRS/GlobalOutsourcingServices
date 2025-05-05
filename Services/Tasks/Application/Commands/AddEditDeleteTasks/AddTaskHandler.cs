using GlobalOutsourcingServices.Services.Tasks.Inferastructure;
using GlobalOutsourcingServices.Services.Tasks.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GlobalOutsourcingServices.Services.Tasks.Application.Command.AddEditDeleteTasks
{
    public class AddTaskHandler : IRequestHandler<AddTaskCommandDTO, string>
    {
       private readonly TasksDbContext _context;
       private readonly TaskService _taskService;

        public async Task<string> Handle(AddTaskCommandDTO request, CancellationToken cancellationToken)
        {


            //_context.TaskModels.Add(request);
            //await _context.SaveChangesAsync();

            //return _taskService.Createask(request);
             
        }
 }

}
