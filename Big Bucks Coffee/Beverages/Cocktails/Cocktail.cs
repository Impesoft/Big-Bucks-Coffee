using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal abstract class Cocktail : Beverage
    {
        public bool HasIce { get; set; }

        public int PercentageAlcohol { get; set; }

        protected Cocktail()
        {
            Name = "Coctail";
            Image = "/Images/iced.jpg";
        }
    }
}