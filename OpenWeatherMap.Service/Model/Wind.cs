using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenWeatherMap.Service.Model
{
    public class Wind
    {
        [JsonPropertyName("speed")]
        public float Speed { get; set; }
        [JsonPropertyName("deg")]
        public int Degree { get; set; }
    }
}
