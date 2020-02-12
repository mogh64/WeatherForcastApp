using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMap.Service.Model
{
    public class WeatherMainInfo
    {
        [JsonPropertyName("temp")]
        public float Temprature { get; set; }
        [JsonPropertyName("pressure")]
        public float Pressure { get; set; }
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
       
    }
}
