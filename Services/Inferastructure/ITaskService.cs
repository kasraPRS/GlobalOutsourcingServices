using GlobalOutsourcingServices.Services.Domain.Entities;
using GlobalOutsourcingServices.Services.Tasks.Persistance;

namespace GlobalOutsourcingServices.Services.Inferastructure
{
    public class TaskService : ITaskCRUDRepository
    {
        private readonly ITaskCRUDRepository _repository;
        private readonly TasksDbContext _context;


        public TaskService(TasksDbContext repository, ITaskCRUDRepository taskCRUDRepository)
        {
            _context = repository;
            _repository = taskCRUDRepository;
        }

        public async Task CreateTask(TaskModel task)
        {
            await _repository.CreateTask(task);
        }

        public async Task UpdateTask(TaskModel task)
        {
            await _repository.UpdateTask(task);
        }

        public async Task DeleteTaskById(int taskId)
        {
            await _repository.DeleteTaskById(taskId);
        }

        public async Task<List<TaskModel>> GetAllTasks()
        {
            return await _repository.GetAllTasks();
        }

        public async Task<TaskModel> GetTaskById(int taskId)
        {
            return await _repository.GetTaskById(taskId);
        }

    }
}
