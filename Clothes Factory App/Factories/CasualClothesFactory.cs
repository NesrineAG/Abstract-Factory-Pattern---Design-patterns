using Clothes_Factory_App.Abstract_products;
using Clothes_Factory_App.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes_Factory_App.Factories
{
    internal class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        
        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
