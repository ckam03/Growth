using System.ComponentModel.DataAnnotations;

namespace GrowthAPI.Models;

public record JournalEntry
{
    [Key]
    public int Id { get; init; }
    public string Title { get; set; } = string.Empty;
    public string Entry { get; set; } = string.Empty;
    public DateTime Created { get; init; }
}