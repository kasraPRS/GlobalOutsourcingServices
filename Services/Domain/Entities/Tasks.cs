using System.ComponentModel.DataAnnotations;

namespace GlobalOutsourcingServices.Services.Domain.Entities
{
    public class TaskModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public string taskType { get; set; }
        public bool taskStatus { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
        public DateTime? lastUpdateTime { get; set; }

    }
}
