using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design 
{
    public class log4NetLogger : Logging
    {
        public override void log(string message)
        {
            Console.WriteLine("logger with log4NetLogger" + message);
        }
    }
}
