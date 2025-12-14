using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class WeatherFacade
    {
        private IService? _weatherService;
        public async Task<decimal> GetOpenWeatherTemp(string city)
        {
            _weatherService = new WeatherService();
            return await _weatherService.GetTempAsync(city);
        }
    }
}
