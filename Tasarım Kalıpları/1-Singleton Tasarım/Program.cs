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
        static CostumManeger _costumManeger;
        private CostumManeger()
        {

        }
        public static CostumManeger CreateAsSingleton()
        {
            return _costumManeger ?? (_costumManeger = new CostumManeger());

        }
        public  void Save()
        { 
            Console.WriteLine("Saved");
            Console.ReadLine();
        }

    }

}
