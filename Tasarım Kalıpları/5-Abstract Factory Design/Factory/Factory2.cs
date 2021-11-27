using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design 
{
    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreatiCaching()
        {
            return new MemChac();
        }

        public override Logging CreatiLogger()
        {
            return new NLogger();
        }
    }

}
