using GlobalOutsourcingServices.Services.Domain.Entities;

public interface ITaskCRUDRepository
    {
        Task<List<TaskModel>> GetAllTaskAsync();
        Task<TaskModel> GetTaskAsyncById(int taskId);
        Task<TaskModel> AddTaskAsync(TaskModel task);
        Task UpdateTaskAsync(TaskModel task);
        Task DeleteTaskAsync(int taskId);
}

