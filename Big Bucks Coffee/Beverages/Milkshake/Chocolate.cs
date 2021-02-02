using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal class Chocolate : _Milkshake
    {
        public Chocolate()
        {
            Name = "Chocolate Shake";
            Price = 5.99;
            Image = "/Images/chocolate.jpg";
            Description = "Three simple ingredients are all it takes to make an easy homemade chocolate milkshake. Vanilla ice cream, ice cold milk, HERSHEY'S Syrup. Blend, pour, sip.";
        }
    }
}