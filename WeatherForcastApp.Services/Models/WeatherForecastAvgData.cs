using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherForcastApp.Services.Models
{
    public class WeatherForecastAvgData
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("day")]
        public string Day { get; set; }
        [JsonPropertyName("temprature")]
        public float AvgTemprature { get; set; }
        [JsonPropertyName("humidity")]
        public int AvgHumidity { get; set; }
        [JsonPropertyName("windSpeed")]
        public float AvgWindSpeed { get; set; }
        [JsonPropertyName("pressure")]
        public float AvgPressure { get; set; }
        [JsonPropertyName("summary")]
        public WeatherSummary WeatherSummary { get; set; }

    }
}
