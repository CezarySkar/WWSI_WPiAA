using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class OpenVault : IVault
    {
        public string GetObject(string type)
        {
            return $"{type} object retrieved from OpenVault.";
        }
    }
}
