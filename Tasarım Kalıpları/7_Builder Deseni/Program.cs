using _7_Builder_Deseni.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Builder_Deseni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDirector  productDirector = new ProductDirector();
            var builder = new OldCustomerProductBuilder(); 
            productDirector.GeneratePrudact(builder);
            var model = builder.GetModel();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.CatagoryName);
            Console.WriteLine(model.DiccountApplied);
            Console.WriteLine(model.DiccountedPrice);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.ProductName);
            Console.ReadLine();



        }
    }
}
