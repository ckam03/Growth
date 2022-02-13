using System.ComponentModel.DataAnnotations;

namespace GrowthAPI.Models
{
    public record Gratitude
    {
        [Key]
        public int Id { get; init; }
        public string Prompt { get; init; } = string.Empty;
    }
}
