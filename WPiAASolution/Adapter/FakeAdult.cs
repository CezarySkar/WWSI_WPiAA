using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class FakeAdult : Adult
    {
        private readonly Teenager _teenager;
        public FakeAdult(Teenager teenager)
        {
            _teenager = teenager;
        }

        public override bool IsAdult()
        {
            return true;
        }

        public override string GetName()
        {
            return _teenager.Name;
        }
    }
}
