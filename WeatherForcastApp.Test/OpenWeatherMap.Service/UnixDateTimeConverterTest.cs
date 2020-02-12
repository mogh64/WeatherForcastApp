using OpenWeatherMap.Service.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;

namespace WeatherForcastApp.Test.OpenWeatherMap.Service
{
    public class UnixDateTimeConverterTest
    {
        [Fact]
        public void TestDate()
        {
            var dateTime = DateTimeFormatter.FormatedToDateTime("2020-02-07 15:00:00");
            dateTime.Year.ShouldBe(2020);
            dateTime.Month.ShouldBe(02);
            dateTime.Day.ShouldBe(07);
        }
    }
}
