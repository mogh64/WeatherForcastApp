using OpenWeatherMap.Service.Contracts;
using OpenWeatherMap.Service.Model;
using System;
using System.Threading.Tasks;
using WeatherForcastApp.Services.Consts;
using WeatherForcastApp.Services.Contracts;
using WeatherForcastApp.Services.Errors;
using WeatherForcastApp.Services.Models;

namespace WeatherForcastApp.Services.Services
{
    public class WeatherForcastService : IWeatherForcastService
    {
        private readonly IWeatherForecast _weatherForecast;
        private readonly IWeatherForecastAverageCalculator _weatherForecastAverageCalculator;
        public WeatherForcastService(IWeatherForecast weatherForecast,
            IWeatherForecastAverageCalculator weatherForecastAverageCalculator)
        {
            this._weatherForecast = weatherForecast;
            this._weatherForecastAverageCalculator = weatherForecastAverageCalculator;
        }
        public async Task<WeatherForcastResponseDto> Get(WeatherForcastRequestDto requestDto)
        {
            WeatherForecastResponse weatherForecastResponse = new WeatherForecastResponse();

            _ = (requestDto.GetRequestValue() switch
            {
                (nameof(requestDto.City), _) => weatherForecastResponse = 
                                            await _weatherForecast.GetWeatherForecastByCityNameAsync(requestDto.City, Countries.Germany),
                (nameof(requestDto.ZipCode), _) => weatherForecastResponse = 
                                            await _weatherForecast.GetWeatherForecastByZipCodeAsync(requestDto.ZipCode, Countries.Germany),
                (_, _) => throw new RequestInvalidException("Input must be identified!")
            });

            return new WeatherForcastResponseDto()
            {
                City = weatherForecastResponse.City.Name,
                Country = weatherForecastResponse.City.Country,
                WeatherForecastAvgDataList = _weatherForecastAverageCalculator
                                             .CalculateAverageForecast(weatherForecastResponse.WeatherForecastDataList),
                RequestTime = DateTime.Now.ToLongTimeString()
            };            
        }
    }
}
