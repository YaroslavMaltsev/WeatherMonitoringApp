using WeatherMonitoringApp_ApiController.Models;

namespace WeatherMonitoringApp_ApiController.Interfaces
{
    public interface IWeatherMonitoringRepository
    {
        public WeatherModel GetWeatherForecastApi(string cityName, string apiKey);
    }
}