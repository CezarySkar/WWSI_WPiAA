using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adult
    {
        public virtual bool IsAdult()
        {
            return true;
        }

        public virtual string GetName()
        {
            return "Anonimowy Dorosły";
        }
    }
}
