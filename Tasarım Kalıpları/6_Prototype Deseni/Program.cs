using _6_Prototype_Deseni.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Prototype_Deseni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_6_Prototype_Deseni");
            Customer customer = new Customer { FirstName="Mikayil",LastName="Aktemur",City="Ankara",Id=1 };
            Console.WriteLine(customer.FirstName);
            var customer1 =(Customer) customer.Clon();
            customer.FirstName = "Salih";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer1.FirstName);
            Console.ReadLine();
        }
    }

}
