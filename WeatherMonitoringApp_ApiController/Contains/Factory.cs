
using WeatherMonitoringApp_ApiController.Interfaces;
using WeatherMonitoringApp_ApiController.Repositories;

namespace WeatherMonitoringApp_ApiController.Contains
{
    // Фабрика по созданию объектов
    public static class Factory
    {
        public static IWeatherMonitoringRepository CreateWeatherRepository()
        {
            return new WeatherMonitoringRepository();
        }

        public static HttpClient CreateHttpClient()
        {
            return new HttpClient();
        }
    }
}
