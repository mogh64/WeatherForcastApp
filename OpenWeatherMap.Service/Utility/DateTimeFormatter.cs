using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap.Service.Utility
{
    public static class DateTimeFormatter
    {
        public static DateTime FormatedToDateTime(string formatedDateTime)
        {
            
            return DateTime.ParseExact(formatedDateTime, "yyyy-MM-dd HH:mm:ss", 
                System.Globalization.CultureInfo.InvariantCulture); 
        }
    }
}
