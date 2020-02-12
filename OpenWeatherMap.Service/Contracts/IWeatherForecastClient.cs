using OpenWeatherMap.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMap.Service.Contracts
{
    public interface IWeatherForecastClient
    {
        Task<WeatherForecastResponse> GetWeatherForecastResponseAsync(Uri uri);
    }
}
