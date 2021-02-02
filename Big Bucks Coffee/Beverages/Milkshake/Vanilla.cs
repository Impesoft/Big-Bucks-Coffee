using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal class Vanilla : _Milkshake
    {
        public Vanilla()
        {
            Name = "Vanilla Shake";
            Price = 5.99;
            //   Image = "/Images/vanilla.jpg";
            Description = "A milkshake, or simply shake, is a drink that is traditionally made by blending cow's milk, ice cream, and flavorings or sweeteners such as butterscotch, caramel sauce, chocolate syrup, fruit syrup, or whole fruit into a thick, sweet, cold mixture.";
        }
    }
}