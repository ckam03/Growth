using GrowthAPI.Data;
using GrowthAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrowthAPI.Controllers;

[ApiController]
[Route("Quote")]
public class QuoteController : ControllerBase
{
    private readonly GrowthDbContext _context;
    
    public QuoteController(GrowthDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Quote>> GetQuoteAsync()
    {
        var random = new Random();
        var length = _context.Quotes.Count();
        var randomId = random.Next(1, length);
        var randomQuote = await _context.Quotes.Where(x => x.Id == randomId).ToListAsync();
        return randomQuote;
    }
    
}