using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class WeatherService : IService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private string _apiKey = "API_KEY";

        public async Task<decimal> GetTempAsync(string city)
        {
            var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var temp = JsonConvert.DeserializeObject<WeatherResponse>(content)!.Main.Temp;

            return temp;
        }
    }
}
