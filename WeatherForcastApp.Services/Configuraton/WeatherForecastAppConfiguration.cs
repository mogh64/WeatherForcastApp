using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherForcastApp.Services.Contracts;
using WeatherForcastApp.Services.Services;

namespace WeatherForcastApp.Services.Configuraton
{
    public static class WeatherForecastAppConfiguration
    {
        public static void AddOpenWeatherForecastAppDependecies(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastAverageCalculator, WeatherForecastAverageCalculator>();
            services.AddTransient<IWeatherForcastService, WeatherForcastService>();
            services.AddSingleton<ICityInfoService, CityInfoFromFileService>();
        }
    }
}
