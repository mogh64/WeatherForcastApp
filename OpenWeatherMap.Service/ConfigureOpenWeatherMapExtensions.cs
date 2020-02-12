using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMap.Service.Contracts;
using OpenWeatherMap.Service.Model;
using OpenWeatherMap.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap.Service
{
    public static class ConfigureOpenWeatherMapExtensions
    {
        public static void AddOpenWeatherMapService(this IServiceCollection services, WeatherForcastRequestConfig baseInput)
        {            
            services.AddHttpClient<OpenWeatherForecastClient>();
            services.AddSingleton<OpenWeatherMapClientFactory>();
            services.AddSingleton<WeatherForcastRequestConfig>(x => baseInput);
            services.AddScoped<IWeatherForecast, WeatherForecast>();
            
     
        }
    }
}
