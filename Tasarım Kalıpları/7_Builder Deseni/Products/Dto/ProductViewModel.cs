using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Builder_Deseni.Products.Dto
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string CatagoryName { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public decimal DiccountedPrice { get; set; }
        public bool DiccountApplied { get; set; }
    }
}
