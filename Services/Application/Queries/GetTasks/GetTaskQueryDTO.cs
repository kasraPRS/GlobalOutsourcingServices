using MediatR;
using System.ComponentModel.DataAnnotations;

namespace GlobalOutsourcingServices.Services.Application.Queries.GetTasks
{
    public class GetTaskQueryDTO : IRequest<string>
    {
        [Required]
        public string taskName { get; set; }
        public string taskDescription { get; set; } = string.Empty;
        [Required]
        public string taskType { get; set; }
        public bool taskStatus { get; set; }
        [Required]
        public DateTime? startTime { get; set; }
        [Required]
        public DateTime? endTime { get; set; }
        public DateTime? lastUpdateTime { get; set; }
    }
}
