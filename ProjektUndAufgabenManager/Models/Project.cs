using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektUndAufgabenManager.Models;

public class Project
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    [Required]
    [MaxLength(150)]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Navigations-Properties
    public Category? Category { get; set; }

    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();

    // Dynamisch berechneter Fortschritt gemäß Konzeption.md
    [NotMapped]
    public double ProgressPercentage
    {
        get
        {
            if (Tasks == null || Tasks.Count == 0)
                return 0.0;

            int completedCount = Tasks.Count(t => t.Status == TaskStatus.Done);
            return Math.Round(((double)completedCount / Tasks.Count) * 100, 1);
        }
    }
}
