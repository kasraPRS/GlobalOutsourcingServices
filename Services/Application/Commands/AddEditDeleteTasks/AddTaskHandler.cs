using GlobalOutsourcingServices.Services.Inferastructure;
using GlobalOutsourcingServices.Services.Tasks.Domain.Entities;
using GlobalOutsourcingServices.Services.Tasks.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UserApi.Services;

namespace GlobalOutsourcingServices.Services.Application.Commands.AddEditDeleteTasks
{
    public class AddTaskHandler : IRequestHandler<AddTaskCommandDTO, string>
    {
        private readonly TasksDbContext _context;
        private readonly TaskService _taskService;
        private readonly ITaskCRUDRepository _taskCRUDRepository;

        public AddTaskHandler(TasksDbContext context, TaskService taskService, ITaskCRUDRepository taskCRUDRepository)
        {
            _context = context;
            _taskService = taskService;
            _taskCRUDRepository = taskCRUDRepository;
        }

        public async Task<string> Handle(AddTaskCommandDTO dto, CancellationToken cancellationToken) {
            var task = new TaskModel
            {
                endTime = dto.endTime,
                lastUpdateTime = dto.lastUpdateTime,
                startTime = dto.startTime,
                taskDescription = dto.taskDescription,
                taskName = dto.taskName,
                taskStatus = dto.taskStatus,
                taskType = dto.taskType,
            };

            await _taskCRUDRepository.CreateTask(task);
        }

    }

}
