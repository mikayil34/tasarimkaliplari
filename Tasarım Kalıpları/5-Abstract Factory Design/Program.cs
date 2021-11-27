using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_5_Abstract_Factory_Design");
            IProductManager _productManager = new ProductManager(new Factory1());
            _productManager.GetAll();
        }
    }

 

   

   

   
   

   
   
}
