using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMap.Service.Model
{
    public class Weather
    {
        [JsonPropertyName("main")]
        public string Main { get; set; }
        
    }
}
