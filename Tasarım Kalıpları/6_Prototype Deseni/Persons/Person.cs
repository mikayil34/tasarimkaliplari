using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Prototype_Deseni.Persons
{
    public abstract class Person
    {
        public abstract Person Clon();

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
