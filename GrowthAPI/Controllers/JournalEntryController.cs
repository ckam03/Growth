using GrowthAPI.Data;
using GrowthAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrowthAPI.Controllers;

[ApiController]
[Route("Entry")]
public class JournalEntryController : ControllerBase
{
    private readonly GrowthDbContext _dbContext;
    public JournalEntryController(GrowthDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task GetEntriesAsync()
    {
        await _dbContext.JournalEntries.ToListAsync();
    }

    [HttpGet("{id}", Name = "GetEntryAsync")]
    public async Task GetEntryAsync(int id)
    {
        await _dbContext.JournalEntries.FindAsync(id);
    }
    
    [HttpPost]
    public async Task <ActionResult<JournalEntry>> CreateEntryAsync(JournalEntry journalEntry)
    {
        var entry = new JournalEntry()
        {
            Id = journalEntry.Id,
            Title = journalEntry.Title,
            Entry = journalEntry.Entry,
            Created = journalEntry.Created,
        };
        await _dbContext.JournalEntries.AddAsync(entry);
        await _dbContext.SaveChangesAsync();
        return CreatedAtAction("GetEntry", new { Id = journalEntry.Id }, entry);
    }
}