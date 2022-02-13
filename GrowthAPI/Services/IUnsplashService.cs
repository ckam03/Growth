using GrowthAPI.Models;

namespace GrowthAPI.Services
{
    public interface IUnsplashService
    {
        Task<UnsplashResponse> GetUnsplashImageAsync();
    }
}
