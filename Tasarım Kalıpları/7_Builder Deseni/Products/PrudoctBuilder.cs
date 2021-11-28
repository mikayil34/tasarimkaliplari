using _7_Builder_Deseni.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Builder_Deseni.Products
{
    public abstract class PrudoctBuilder
    { 
        public abstract void GetProductData(); 
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();

    }
}
