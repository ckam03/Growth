using GrowthAPI.Data;
using GrowthAPI.Dtos;
using GrowthAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrowthAPI.Controllers
{
    [ApiController]
    [Route("Gratitude")]
    public class GratitudeController : ControllerBase
    {
        private readonly GrowthDbContext _context;
        
        public GratitudeController(GrowthDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Gratitude>> GetGratitudePromptsAsync()
        {
            var random = new Random();
            var length = _context.GratitudePrompts.Count();
            var randomId = random.Next(1,length);
            var randomPrompt = await _context.GratitudePrompts
                .Where(x => x.Id == randomId)
                .ToListAsync();
            return randomPrompt;
        }
        /*[HttpGet("id")]
        public async Task<IEnumerable<Gratitude>> GetGratitudePromptAsync()
        {            return await _context.GratitudePrompts.               

        }*/
    }
}
