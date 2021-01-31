using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal abstract class Milkshake : Beverage
    {
        public bool HasDairy { get; set; }
        public bool HasWhippedCream { get; set; }

        public Milkshake()
        {
            Name = "Milkshake";
            Image = "/Images/vanilla.jpg";
        }
    }
}