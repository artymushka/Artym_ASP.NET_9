using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;
        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetWeather(string cityName)
        {
            try
            {
                var weatherInfo = await _weatherService.GetWeatherAsync(cityName);
                return View("Weather", weatherInfo);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}