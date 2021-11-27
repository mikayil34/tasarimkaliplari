using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design 
{
    public class MemChac : Caching
    {
        public override void Cach(string message)
        {
            Console.WriteLine("Caching with MemChac" + message);
        }
    }
}
