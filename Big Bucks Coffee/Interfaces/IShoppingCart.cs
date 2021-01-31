using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    public interface IShoppingCart
    {
        void AddBeverageToCart(IBeverage beverage); 
    }
}
