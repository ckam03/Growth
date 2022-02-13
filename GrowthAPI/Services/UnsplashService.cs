using GrowthAPI.Models;
using System.Text.Json;

namespace GrowthAPI.Services
{
    public class UnsplashService : IUnsplashService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        public UnsplashService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.unsplash.com");
            _apiKey = configuration["Growth:ServiceApiKey"];
        }

        public async Task<UnsplashResponse> GetUnsplashImageAsync()
        {
            var request = await _httpClient.GetAsync($"/photos/random?client_id={_apiKey}&count=1&collections=327760");
            request.EnsureSuccessStatusCode();
            var response = await request.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<List<UnsplashResponse>>(response);
            return result.First();
        }
    }
}
