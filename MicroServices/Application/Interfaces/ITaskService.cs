using GlobalOutsourcingServices.Services.Application.Commands.AddEditDeleteTasks;
using GlobalOutsourcingServices.Services.Domain.Entities;
using UserApi.Services;

    public interface ITaskService
    {
        Task<List<TaskDTO>> GetAllTaskAsync();
        Task<ServiceResponse<TaskDTO>> GetTaskAsyncById(int taskId);
        Task<ServiceResponse<TaskDTO>> AddTaskAsync(AddTaskCommand task);
        Task<ServiceResponse<TaskDTO>> UpdateTaskAsync(AddTaskCommand task);
        Task<ServiceResponse<TaskDTO>> DeleteTaskAsync(int taskId);

}
