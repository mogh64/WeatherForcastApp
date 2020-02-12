using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherForcastApp.Services.Models
{
    public class WeatherForcastResponseDto
    {
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("avgForcasts")]
        public IEnumerable<WeatherForecastAvgData> WeatherForecastAvgDataList { get; set; }
        [JsonPropertyName("requestTime")]
        public string RequestTime { get; set; }

    }
}
