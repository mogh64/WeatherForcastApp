using LazyCache;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForcastApp.Services.Consts;
using WeatherForcastApp.Services.Contracts;
using WeatherForcastApp.Services.Models;

namespace WeatherForcastApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityInfoController : ControllerBase
    {
        private readonly ICityInfoService _cityInfoService;
        private readonly IAppCache _cache;

        public CityInfoController(ICityInfoService cityInfoService, IAppCache cache)
        {
            this._cityInfoService = cityInfoService;
            this._cache = cache;
        }
        [HttpGet]
        public async Task<IEnumerable<CityDto>> Get([FromQuery] CityRequestDto query)
        {
            var country = Countries.Germany;
            Func<Task<IEnumerable<CityDto>>> cityInfoCache = () => _cityInfoService.GetCities(country);
            var citiesOfCountry = await _cache.GetOrAddAsync<IEnumerable<CityDto>>($"citiesOf{country}", cityInfoCache, DateTimeOffset.Now.AddHours(24));
            return citiesOfCountry.Where(x => x.Name.ToLower().StartsWith(query.Name.ToLower())).ToList();
        }
    }
}