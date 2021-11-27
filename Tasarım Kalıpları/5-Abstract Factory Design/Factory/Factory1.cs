using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design 
{
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreatiCaching()
        {
            return new RedisChac();
        }

        public override Logging CreatiLogger()
        {
            return new log4NetLogger();
        }
    }
}
