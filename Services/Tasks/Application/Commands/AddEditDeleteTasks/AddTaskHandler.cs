using AutoMapper;
using GlobalOutsourcingServices.Services.Domain.Entities;
using GlobalOutsourcingServices.Services.Inferastructure;
using GlobalOutsourcingServices.Services.Persistance;
using MediatR;
using UserApi.Services;

namespace GlobalOutsourcingServices.Services.Application.Commands.AddEditDeleteTasks
{
    public class AddTaskHandler : IRequestHandler<AddTaskCommand, ServiceResponse<TaskDTO>>
    {
        private readonly ApplicationDbContext _context;
        private readonly TaskService _taskService;
        private readonly ITaskCRUDRepository _taskCRUDRepository;
        private readonly IMapper _mapper;

        public AddTaskHandler(ApplicationDbContext context, TaskService taskService, ITaskCRUDRepository taskCRUDRepository, IMapper mapper)
        {
            _context = context;
            _taskService = taskService;
            _taskCRUDRepository = taskCRUDRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<TaskDTO>> Handle(AddTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItem = _mapper.Map<TaskModel>(request);

            var data = _mapper.Map<TaskDTO>(request);
            await _taskCRUDRepository.AddTaskAsync(taskItem);

            return new ServiceResponse<TaskDTO>
            {
                Success = true,
                Message = "TASK_ADD_SUCCESSFULL",
                Data = data
            };
        }
    }

}
