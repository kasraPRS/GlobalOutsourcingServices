using AutoMapper;
using GlobalOutsourcingServices.Services.Application.Commands.AddEditDeleteTasks;
using GlobalOutsourcingServices.Services.Domain.Entities;
using MediatR;
using UserApi.Services;

namespace GlobalOutsourcingServices.Services.Inferastructure
{
    public class TaskService : ITaskService
    {
        private readonly ITaskCRUDRepository _repository;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;


        public TaskService(IMediator mediator, ITaskCRUDRepository taskCRUDRepository,IMapper mapper)
        {
            _repository = taskCRUDRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<ServiceResponse<TaskDTO>> AddTaskAsync(AddTaskCommand command)
        {
            var addTaskCommand = _mapper.Map<AddTaskCommand>(command);

            var data = _mapper.Map<TaskDTO>(command);

            var responce = await _mediator.Send(addTaskCommand);

            return responce.Success
            ? new ServiceResponse<TaskDTO> { Success = true, Data = data, Message = "TASK_ADD_SUCCESSFULL" }
            : new ServiceResponse<TaskDTO> { Success = false, Data = null, Message = "SOMETHING_GET_WRONG" };

        }

        public Task<ServiceResponse<TaskDTO>> DeleteTaskAsync(int taskId)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskDTO>> GetAllTaskAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TaskDTO>> GetTaskAsyncById(int taskId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TaskDTO>> UpdateTaskAsync(AddTaskCommand task)
        {
            throw new NotImplementedException();
        }
    }
}
