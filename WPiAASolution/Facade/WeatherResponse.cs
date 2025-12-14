using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class WeatherResponse
    {
        [JsonProperty("main")]
        public MainInfo Main { get; set; }
    }

    internal class MainInfo
    {
        [JsonProperty("temp")]
        public decimal Temp { get; set; }
    }
}
