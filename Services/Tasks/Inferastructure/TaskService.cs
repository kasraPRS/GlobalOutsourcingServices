using GlobalOutsourcingServices.Services.Tasks.Application.Command.AddEditDeleteTasks;
using GlobalOutsourcingServices.Services.Tasks.Application.Interfaces;
using GlobalOutsourcingServices.Services.Tasks.Domain.Entities;

namespace GlobalOutsourcingServices.Services.Tasks.Inferastructure
{
    public class TaskService : ITaskCRUDRepository
    {
        private readonly ITaskCRUDRepository _repository;

        public TaskService(ITaskCRUDRepository repository)
        {
            _repository = repository;
        }

        public async Task Createask(TaskModel task)
        {
            await _repository.Createask(task);
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

        public async Task UpdateTask(TaskModel task)
        {
            await _repository.UpdateTask(task);
        }
    }
}
