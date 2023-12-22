

using WeatherMonitoringApp_UI.interfaces;
using WeatherMonitoringApp_UI.ViewModels;

namespace WeatherMonitoringApp_UI.Contains
{
    public static class Factory
    {
        public static IWeatherViewModel CreateWeatherViewModel()
        {
            return new WeatherViewModel();
        }
    }
}
