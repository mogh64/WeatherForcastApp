using OpenWeatherMap.Service.Contracts;
using OpenWeatherMap.Service.Model;
using OpenWeatherMap.Service.Utility;
using System.Threading.Tasks;

namespace OpenWeatherMap.Service.Services
{
    public class WeatherForecast : IWeatherForecast
    {
        private readonly OpenWeatherMapClientFactory _openWeatherMapClientFactory;
        WeatherForecastUriBuilder _weatherForecastUriBuilder;
        public WeatherForecast(OpenWeatherMapClientFactory openWeatherMapClientFactory,
                                WeatherForcastRequestConfig requestConfig)
        {
            this._openWeatherMapClientFactory = openWeatherMapClientFactory;
            _weatherForecastUriBuilder = new WeatherForecastUriBuilder(requestConfig);
        }
        public Task<WeatherForecastResponse> GetWeatherForecastByCityNameAsync(string cityName, string countryCode)
        {
            var uri = _weatherForecastUriBuilder.CreateByCityUri(cityName, countryCode);
            return _openWeatherMapClientFactory.Create().GetWeatherForecastResponseAsync(uri);
        }
        public Task<WeatherForecastResponse> GetWeatherForecastByZipCodeAsync(string zipCode, string countryCode)
        {
            var uri = _weatherForecastUriBuilder.CreateByZipCodeUri(zipCode, countryCode);
            return _openWeatherMapClientFactory.Create().GetWeatherForecastResponseAsync(uri);
        }
    }
}
