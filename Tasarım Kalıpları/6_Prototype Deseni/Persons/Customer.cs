using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Prototype_Deseni.Persons
{
    public class Customer : Person
    { 
        public string City { get; set; }

        public override Person Clon()
        {
            return (Person)MemberwiseClone();
        }
    }
}
