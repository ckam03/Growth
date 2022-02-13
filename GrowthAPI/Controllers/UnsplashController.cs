using GrowthAPI.Models;
using GrowthAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrowthAPI.Controllers
{
    [ApiController]
    [Route("Image")]
    public class UnsplashController : ControllerBase
    {
        private readonly IUnsplashService _unsplashService;
        public UnsplashController(IUnsplashService unsplashService)
        {
            _unsplashService = unsplashService;
        }
        [HttpGet]
        public async Task<UnsplashResponse> GetUnsplashImage()
        {
            return await _unsplashService.GetUnsplashImageAsync();
        }
    }
}
