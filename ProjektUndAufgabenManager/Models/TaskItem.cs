using System.ComponentModel.DataAnnotations;

namespace ProjektUndAufgabenManager.Models;

public class TaskItem
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    public TaskStatus Status { get; set; } = TaskStatus.Open;

    public TaskPriority Priority { get; set; } = TaskPriority.Medium;

    public DateTime? DueDate { get; set; }

    // Navigations-Property
    public Project? Project { get; set; }
}
