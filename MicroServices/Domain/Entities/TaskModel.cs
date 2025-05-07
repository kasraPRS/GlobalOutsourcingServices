using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalOutsourcingServices.Services.Domain.Entities
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public required string TaskName { get; set; }
        [MaxLength(256)]
        public required string TaskDescription { get; set; }
        public required string TaskType { get; set; }
        public bool TaskStatus { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }

    }
}
