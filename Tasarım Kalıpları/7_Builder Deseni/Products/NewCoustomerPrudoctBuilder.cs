using _7_Builder_Deseni.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Builder_Deseni.Products
{
    public class NewCoustomerPrudoctBuilder : PrudoctBuilder
    {
        ProductViewModel model= new ProductViewModel();  
        public override void GetProductData()
        {
            model.Id=1;
            model.CatagoryName="Beverage";
            model.ProductName="Chai";
            model.UnitPrice=20;  
        }
        public override void ApplyDiscount()
        {
            model.DiccountedPrice = (decimal)(model.UnitPrice * 0.90);
            model.DiccountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }


    }
}
