using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMap.Service.Model
{
    public class WeatherForecastResponse
    {
        [JsonPropertyName("list")]
        public IEnumerable<WeatherForecastData> WeatherForecastDataList { get; set; }
        [JsonPropertyName("cod")]
        public string Code { get; set; }
        public string Message { get; set; }
        [JsonPropertyName("cnt")]
        public int Count { get; set; }
        [JsonPropertyName("city")]
        public City City { get; set; }
    }
}
