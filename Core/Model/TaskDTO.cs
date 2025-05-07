using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TaskDTO
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string taskName { get; set; }
    public required string taskDescription { get; set; }
    public required string taskType { get; set; }
    public bool taskStatus { get; set; }
    public DateTime? startTime { get; set; }
    public DateTime? endTime { get; set; }
    public DateTime? lastUpdateTime { get; set; }
}