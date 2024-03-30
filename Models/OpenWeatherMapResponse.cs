namespace WebApplication1.Models
{
    public class OpenWeatherMapResponse
    {
        public string Name { get; set; }
        public MainData Main { get; set; }
        public Weather[] Weather { get; set; }
        public Sys Sys { get; set; }
    }
}
