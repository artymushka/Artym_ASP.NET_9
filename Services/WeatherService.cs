using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Services
{ 
    public class WeatherService{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://api.openweathermap.org");
    }

    public async Task<WeatherModel> GetWeatherAsync(string cityName)
    {
        try
        {
            string apiKey = "b3934d3ff24532b0c86795101aff2d0e";
            string requestUrl = $"/data/2.5/weather?q={cityName}&appid={apiKey}";

            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();

            var weatherData = JsonConvert.DeserializeObject<OpenWeatherMapResponse>(jsonString);

            var weatherModel = new WeatherModel
            {
                City = weatherData.Name,
                Country = weatherData.Sys.Country,
                Temperature = weatherData.Main.Temperature - 273.15,
                Description = weatherData.Weather[0].Description
            };

            return weatherModel;
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to get weather data.", ex);
        }
    }
}

}
