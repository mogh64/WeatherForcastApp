using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcastApp.Services.Tools
{
    public class CityInfoJsonReader
    {
        public async  Task<string> ReadJsonFile(string country)
        {
            var path = GetFilePath(country);
            var jsonString = File.ReadAllTextAsync(path);
            return await jsonString;            
        }
        private  string GetFilePath(string country)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Json", $"{country}.json");
            return path;
        }
    }
}
