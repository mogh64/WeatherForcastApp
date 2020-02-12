using OpenWeatherMap.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherForcastApp.Services.Models;

namespace WeatherForcastApp.Services.Contracts
{
    public interface IWeatherForecastAverageCalculator
    {
         IEnumerable<WeatherForecastAvgData> CalculateAverageForecast(IEnumerable<WeatherForecastData> weatherForecastInputList);
    }
}
