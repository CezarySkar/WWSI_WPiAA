using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Garnizon
    {
        public StrzelectBuilder StrzelectBuilder;
        public KonnyBuilder KonnyBuilder;
        public PiechurBuilder PiechurBuilder;

        public Garnizon()
        {
            StrzelectBuilder = new StrzelectBuilder();
            KonnyBuilder = new KonnyBuilder();
            PiechurBuilder = new PiechurBuilder();
        }
    }
}
