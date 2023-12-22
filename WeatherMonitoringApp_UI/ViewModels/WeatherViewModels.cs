using WeatherMonitoringApp_ApiController.Contains;
using WeatherMonitoringApp_UI.interfaces;

namespace WeatherMonitoringApp_UI.ViewModels
{
    internal class WeatherViewModel() : IWeatherViewModel
    {

        public (string, string, string) GetWeatherView(string cityName, string apiKey)
        {
            // создание объекта WeatherMonitoringRepository
            var weather = Factory.CreateWeatherRepository();

            var weatherInfo =  weather.GetWeatherForecastApi(cityName, apiKey);

            return (weatherInfo.Temperature, weatherInfo.Description, weatherInfo.WindSpeed);
        }
    }
}
