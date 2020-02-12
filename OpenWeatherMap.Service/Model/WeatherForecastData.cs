using OpenWeatherMap.Service.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMap.Service.Model
{
    public class WeatherForecastData
    {
        [JsonConverter(typeof(JsonDateTimeConverter)), JsonPropertyName("dt_txt")]
        public DateTime DateTime { get; set; }
        [JsonPropertyName("main")]
        public WeatherMainInfo WeatherMainInfo { get; set; }
        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }
        [JsonPropertyName("weather")]
        public  IEnumerable<Weather> Weather { get; set; }
    }
}
