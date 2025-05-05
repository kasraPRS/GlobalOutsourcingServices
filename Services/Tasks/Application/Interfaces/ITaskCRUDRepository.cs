using GlobalOutsourcingServices.Services.Tasks.Domain.Entities;

    public interface ITaskCRUDRepository
    {
        Task<List<TaskModel>> GetAllTasks();
        Task<TaskModel> GetTaskById(int taskId);
        Task CreateTask(TaskModel task);
        Task UpdateTask(TaskModel task);
        Task DeleteTaskById(int taskId);
    }

