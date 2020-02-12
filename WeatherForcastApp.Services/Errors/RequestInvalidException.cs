using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WeatherForcastApp.Services.Errors
{
    public class RequestInvalidException : Exception
    {
        public RequestInvalidException(string message)
            :base(message)
        {

        }

   
    }
}
