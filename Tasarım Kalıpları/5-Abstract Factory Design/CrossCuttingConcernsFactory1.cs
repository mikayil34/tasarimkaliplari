using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design
{
    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreatiLogger();
        public abstract Caching CreatiCaching();

    }
}
