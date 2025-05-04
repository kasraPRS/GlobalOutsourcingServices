using GlobalOutsourcingServices.Services.Tasks.Domain.Entities;

namespace GlobalOutsourcingServices.Services.Tasks.Application.Interfaces
{
    public interface ITaskCRUDRepository
    {
        Task<List<TaskModel>> GetAllTasks();
        Task<TaskModel> GetTaskById(int taskId);
        Task Createask(TaskModel task);
        Task UpdateTask(TaskModel task);
        Task DeleteTaskById(int taskId);
    }
}
