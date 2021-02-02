using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal class Macchiato : _Espresso
    {
        public Macchiato()

        {
            Name = "Macchiato";
            Price = 2.99;

            Image = "/Images/macchiato.jpg";

            Description = "Caffè macchiato, sometimes called espresso macchiato, is an espresso coffee drink with a small amount of milk, usually foamed. In Italian, macchiato means \"stained\" or \"spotted\" so the literal translation of caffè macchiato is \"stained\" or \"marked coffee.\"";
        }
    }
}