using OpenWeatherMap.Service.Consts;
using OpenWeatherMap.Service.Errors;
using OpenWeatherMap.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap.Service.Utility
{
    public class WeatherForecastUriBuilder
    {
        private readonly WeatherForcastRequestConfig _forcastInput;

        public WeatherForecastUriBuilder(WeatherForcastRequestConfig forcastInput)
        {
            this._forcastInput = forcastInput;
        }
        public Uri CreateByCityUri(string city,string countryCode)
        {
            if (string.IsNullOrEmpty(city))
                throw new ArgumentNullException(nameof(city), ErrorMessages.CanNotBeNullOrEmpty(nameof(city)));            
            UriBuilder builder = new UriBuilder(GetUri($"q={ city },{countryCode}"));
            return builder.Uri;
        }
        public Uri CreateByZipCodeUri(string zipCode, string countryCode)
        {
            if (string.IsNullOrEmpty(zipCode))
                throw new ArgumentNullException(nameof(zipCode), ErrorMessages.CanNotBeNullOrEmpty(nameof(zipCode)));            
            UriBuilder builder = new UriBuilder(GetUri($"zip={zipCode},{countryCode}"));
            return builder.Uri;
        }
        private string GetUri(string queryParam)
        {
            return $"http://{OpenWeatherForecastApiConsts.BaseAddress}{OpenWeatherForecastApiConsts.ApiVersion}{OpenWeatherForecastApiConsts.WeatherForcastRequestRoot}?{queryParam}&units={OpenWeatherForecastApiConsts.WeatherUnit}&appid={_forcastInput.ApiKey}";
        }
    }
}
