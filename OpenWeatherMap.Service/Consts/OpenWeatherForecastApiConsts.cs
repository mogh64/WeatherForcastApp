using OpenWeatherMap.Service.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap.Service.Consts
{
    public static class OpenWeatherForecastApiConsts
    {
        /// <summary>
        /// OpenWeatherMap API Key
        /// </summary>
        
        private const string Base_Address = "api.openweathermap.org/data";
        private const string API_VERSION = "/2.5";
        private const string WEATHER_REQUESTS_ROOT = "/forecast";
        private const string WEATHER_UNIT = nameof(ForecastUnitEnum.Metric);


        public static string BaseAddress
        {
            get
            {
                return Base_Address;
            }
        }
        public static string ApiVersion
        {
            get
            {
                return API_VERSION;
            }
        }
        public static string WeatherForcastRequestRoot
        {
            get
            {
                return WEATHER_REQUESTS_ROOT;
            }
        }
        public static string WeatherUnit
        {
            get
            {
                return WEATHER_UNIT;
            }
        }
    }
}
