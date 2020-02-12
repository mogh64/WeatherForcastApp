using OpenWeatherMap.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using WeatherForcastApp.Services.Contracts;
using WeatherForcastApp.Services.Models;

namespace WeatherForcastApp.Services.Services
{
    public class WeatherForecastAverageCalculator : IWeatherForecastAverageCalculator
    {
        public IEnumerable<WeatherForecastAvgData> CalculateAverageForecast(IEnumerable<WeatherForecastData> weatherForecastInputList)
        {
            var weatherForecastAvgOutputDataList = weatherForecastInputList.GroupBy(x => x.DateTime.Date)
                .Select(x =>
                new WeatherForecastAvgData()
                {
                    AvgHumidity = (int)x.Average(p => p.WeatherMainInfo.Humidity),
                    AvgWindSpeed = (float)x.Average(p => p.Wind.Speed),
                    AvgTemprature = (float)x.Average(p => p.WeatherMainInfo.Temprature),
                    Date = x.Key.Date,
                    Day = x.Key.Date.ToString("ddd"),
                    AvgPressure = (float)x.Average(p => p.WeatherMainInfo.Pressure),
                    WeatherSummary = GetWeatherSummary(x.Select(x => x.Weather.First()?.Main))
                }
                ).ToList();

            return weatherForecastAvgOutputDataList;
        }
        private WeatherSummary GetWeatherSummary(IEnumerable<string> weatherStates)
        {
            string weatherState = weatherStates.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            return new WeatherSummary()
            {
                Weather = weatherState
            };
        }
        
    }
}
