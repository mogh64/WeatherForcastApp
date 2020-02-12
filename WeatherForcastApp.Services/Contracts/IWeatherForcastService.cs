using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherForcastApp.Services.Models;

namespace WeatherForcastApp.Services.Contracts
{
    public interface IWeatherForcastService
    {
        Task<WeatherForcastResponseDto> Get(WeatherForcastRequestDto requestDto);
    }
}
