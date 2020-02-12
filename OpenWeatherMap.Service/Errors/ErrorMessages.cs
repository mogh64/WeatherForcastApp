using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap.Service.Errors
{
    public static class ErrorMessages
    {
        public static string CanNotBeNullOrEmpty(string propertyName)
        {
            return $"{propertyName} can NOT be null or empty string";
        }
    }
}
