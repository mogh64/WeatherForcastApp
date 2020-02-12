using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMap.Service.Errors
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public NotFoundException()
        {
        }
    }
}
