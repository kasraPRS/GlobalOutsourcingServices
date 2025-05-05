using MediatR;

namespace GlobalOutsourcingServices.Services.Application.Commands.AddEditDeleteTasks
{
    public class AddTaskCommandDTO : IRequest<string>
    {

        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public string taskType { get; set; }
        public bool taskStatus { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
        public DateTime? lastUpdateTime { get; set; }
    }
}
