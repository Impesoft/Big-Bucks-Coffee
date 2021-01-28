using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Bucks_Coffee
{
    internal class ShoppingCart
    {
        private List<IBeverage> _beverages;

        public void AddItemToCart(IBeverage beverage)
        {
            _beverages.Add(beverage);
        }

        public double CalculatePrice(IEnumerable<IBeverage> beverages)
        {
            return 0.0;
        }

        public double CalculateTax()
        {
            return 0.0;
        }

        public void ClearCart()
        {
            _beverages.Clear();
        }

        public List<IBeverage> GetItemsInCart()
        {
            return new List<IBeverage>();
        }
    }
}