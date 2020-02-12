using System;
using System.Collections.Generic;
using System.Text;
using WeatherForcastApp.Services.Contracts;
using WeatherForcastApp.Services.Errors;

namespace WeatherForcastApp.Services.Models
{
    public class WeatherForcastRequestDto : IRequestValidate
    {
        public string City { get; set; }
        public string ZipCode { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(GetRequestValue().value))
            {
                throw new RequestInvalidException("at least city or zipCode must identified!");
            }
        }
        public (string key,string value) GetRequestValue()
        {
            if (!string.IsNullOrWhiteSpace(City))
            {
                return (nameof(City), City);
            }               
            if (!string.IsNullOrWhiteSpace(ZipCode))
            {
                return (nameof(ZipCode), ZipCode);
            }
            return (null,null);
        }        
    }
}
