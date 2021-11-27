using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design 
{
    public class NLogger : Logging
    {
        public override void log(string message)
        {
            Console.WriteLine("logger with NLogger" + message);
        }
    }
}
