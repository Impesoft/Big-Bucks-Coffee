using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Big_Bucks_Coffee
{
    internal class Espresso : Coffee
    {
        //public typeOfRoast TypeOfRoast { get; set; }

        public Espresso()
        {
            Name = "Espresso";
            Price = 2.99;
            Image = "/Images/espresso.jpg";
            Description = "Espresso is a coffee-brewing method of Italian origin, in which a small amount of nearly boiling water is forced under 9–10 bars of atmospheric pressure through finely-ground coffee beans. Espresso coffee can be made with a wide variety of coffee beans and roast degrees.";
        }
    }
}