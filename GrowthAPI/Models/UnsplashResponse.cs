namespace GrowthAPI.Models
{
    public class UnsplashResponse
    {
        public string id { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public urls? urls { get; set; }
    }
    public class urls
    {
        public string small { get; set; } = string.Empty;
    }
}
