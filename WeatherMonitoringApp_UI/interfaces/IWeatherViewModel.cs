namespace WeatherMonitoringApp_UI.interfaces
{
    public interface IWeatherViewModel
    {
        (string, string, string) GetWeatherView(string cityName, string apiKey);
    }
}