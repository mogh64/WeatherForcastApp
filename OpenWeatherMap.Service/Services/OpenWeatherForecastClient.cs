using OpenWeatherMap.Service.Contracts;
using OpenWeatherMap.Service.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using OpenWeatherMap.Service.Errors;

namespace OpenWeatherMap.Service.Services
{
    public class OpenWeatherForecastClient : IWeatherForecastClient
    {
        private readonly HttpClient _httpClient;
        public OpenWeatherForecastClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }
        
        public async Task<WeatherForecastResponse> GetWeatherForecastResponseAsync(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri), ErrorMessages.CanNotBeNullOrEmpty(nameof(uri)));
            }
            try
            {
                var streamTask = _httpClient.GetStreamAsync(uri).ConfigureAwait(false);
                return await JsonSerializer.DeserializeAsync<WeatherForecastResponse>(await streamTask);
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    throw new NotFoundException(ex.Message);
                }
                throw;
            }
                                                
        }
        
    }
}
