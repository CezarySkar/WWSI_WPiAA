using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Ork
    {
        public int Strength { get; set; }

        public Ork Clone()
        {
            string copy = JsonConvert.SerializeObject(this);
            Ork newOrk = JsonConvert.DeserializeObject<Ork>(copy)!;
            newOrk.Strength = new Random().Next(1, 100);

            return newOrk;
        }
    }
}
