using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherForcastApp.Services.Models
{
    public class WeatherSummary
    {
        [JsonPropertyName("weather")]
        public string Weather { get; set; }     
    }
}
