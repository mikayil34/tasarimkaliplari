using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Singleton_Tasarım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var costumManeger = CostumManeger.CreateAsSingleton();
            costumManeger.Save();

        }

    }

    class CostumManeger
    {
        static object _logObject = new object();
        static CostumManeger _costumManeger;
        private CostumManeger()
        {

        }
        public static CostumManeger CreateAsSingleton()
        {
            lock (_logObject)
            {
                if (_costumManeger == null)
                {
                    _costumManeger = new CostumManeger();
                }

            }
            return _costumManeger;
        }
        public void Save()
        {
            Console.WriteLine("Saved");
            Console.ReadLine();
        }

    }

}
