using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal abstract class _Cocktail : Beverage
    {
        public bool HasIce { get; set; }

        public int PercentageAlcohol { get; set; }

        protected _Cocktail()
        {
            Name = "Coctail";
            Image = "/Images/Cocktail.png";
            DefaultImage = "/Images/Cocktail.png";
        }
    }
}