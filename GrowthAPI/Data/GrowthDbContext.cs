using GrowthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GrowthAPI.Data
{
    public class GrowthDbContext : DbContext
    {
        public GrowthDbContext(DbContextOptions<GrowthDbContext> options) : base(options) { }
        public DbSet<Gratitude> GratitudePrompts { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
    }
}
