using MediatR;
using UserApi.Services;

namespace GlobalOutsourcingServices.Services.Application.Commands.AddEditDeleteTasks
{
    public class AddTaskCommand : IRequest<ServiceResponse<TaskDTO>>
    {

        public required string TaskName { get; set; }
        public required string TaskDescription { get; set; }
        public required string TaskType { get; set; }
        public bool TaskStatus { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
        public DateTime? lastUpdateTime { get; set; }
    }
}
