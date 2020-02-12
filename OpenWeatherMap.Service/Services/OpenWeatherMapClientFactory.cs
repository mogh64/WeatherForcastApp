using Microsoft.Extensions.DependencyInjection;
using OpenWeatherMap.Service.Contracts;
using System;

namespace OpenWeatherMap.Service.Services
{
    public class OpenWeatherMapClientFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public OpenWeatherMapClientFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IWeatherForecastClient Create()
        {
            return _serviceProvider.GetRequiredService<OpenWeatherForecastClient>();
        }
    }
}
