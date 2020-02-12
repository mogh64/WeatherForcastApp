using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherForcastApp.Services.Contracts;
using WeatherForcastApp.Services.Models;
using WeatherForcastApp.Services.Tools;

namespace WeatherForcastApp.Services.Services
{
    public class CityInfoFromFileService : ICityInfoService
    {
        public CityInfoFromFileService()
        {

        }
        public async Task<IEnumerable<CityDto>> GetCities(string country)
        {            
            var cityInfoJson = await new CityInfoJsonReader().ReadJsonFile(country);
            var cityList = JsonSerializer.Deserialize<IEnumerable<CityDto>>(cityInfoJson);
            return cityList;
        }       
    }
}
