using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherForcastApp.Services.Models
{
    public class CityDto
    {
       
        [JsonPropertyName("city")]
        public string Name { get; set; }
        [JsonPropertyName("admin")]
        public string Capital { get; set; }    
    }
}
