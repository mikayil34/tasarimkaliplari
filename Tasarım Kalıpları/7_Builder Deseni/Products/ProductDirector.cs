using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Builder_Deseni.Products
{
   public class ProductDirector
    {

        public void GeneratePrudact(PrudoctBuilder prudoctBuilder)
        {
            prudoctBuilder.GetProductData();
            prudoctBuilder.ApplyDiscount();


        }
    }
}
