using LazyCache;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherForcastApp.Services.Contracts;
using WeatherForcastApp.Services.Models;


namespace WeatherForcastApp.Web.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/weather/forcast")]
    public class WeatherForecastController : ControllerBase
    {        
        private readonly IWeatherForcastService _weatherForcastService;
        private readonly IAppCache _cache;

        public WeatherForecastController(IWeatherForcastService weatherForcastService, IAppCache cache)
        {
            this._weatherForcastService = weatherForcastService;
            this._cache = cache;
        }

        [HttpGet]
        public  Task<WeatherForcastResponseDto> Get([FromQuery] WeatherForcastRequestDto requestDto)
        {
            requestDto.Validate();
            Func<Task<WeatherForcastResponseDto>> weatherForecastCache = () =>  _weatherForcastService.Get(requestDto);
            return _cache.GetOrAddAsync<WeatherForcastResponseDto>(requestDto.GetRequestValue().value, weatherForecastCache, DateTimeOffset.Now.AddHours(1));
        }          
    }
}
