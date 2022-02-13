using System.ComponentModel.DataAnnotations;

namespace GrowthAPI.Models
{
    public record Quote
    {
        [Key]
        public int Id { get; init; }
        public string QuoteContent { get; init; } = string.Empty;
        public string Author { get; init; } = string.Empty;
    }
}
