using OpenWeatherMap.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap.Service.Contracts
{
    public interface IWeatherForecast
    {
        Task<WeatherForecastResponse> GetWeatherForecastByCityNameAsync(string cityName, string countryCode);
        Task<WeatherForecastResponse> GetWeatherForecastByZipCodeAsync(string zipCode, string countryCode);
    }
}
