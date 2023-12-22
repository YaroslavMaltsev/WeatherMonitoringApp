using Newtonsoft.Json.Linq;
using WeatherMonitoringApp_ApiController.Contains;
using WeatherMonitoringApp_ApiController.Interfaces;
using WeatherMonitoringApp_ApiController.Models;

namespace WeatherMonitoringApp_ApiController.Repositories
{
    public class WeatherMonitoringRepository() : IWeatherMonitoringRepository
    {

        public  WeatherModel GetWeatherForecastApi(string cityName, string apiKey)
        {
            try
            {
                // Получаем экземпляр объекта HttpClient
                var httpClient = Factory.CreateHttpClient();
                //Ссылка для доступа к API
                var userURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";
                //Получение ответа от API
                var weatherResponse = httpClient.GetStringAsync(userURL).Result;
                // Создаём экземпляр модели
                WeatherModel weatherModel = new();
                // Десериализазия объекта
                dynamic d = JObject.Parse(weatherResponse);
                // Выборка данных из Json
                weatherModel.Temperature = (d.main.temp);
                weatherModel.WindSpeed = (d.wind.speed);
                weatherModel.Description = (d.weather[0].description);

                return weatherModel;
            }
            catch (Exception)
            {
                throw new Exception("Что-то пошло не так при получение данных");
            }
        }
    }
}
