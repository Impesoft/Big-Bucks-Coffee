using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal class Green : _Tea
    {
        public Green()
        {
            Name = "Green Tea";
            Price = 2.99;
            Image = "/Images/green.jpg";
            Description = "Green tea is a type of tea that is made from Camellia sinensis leaves and buds that have not undergone the same withering and oxidation process used to make oolong teas and black teas. Green tea originated in China, but its production and manufacture has spread to other countries in East Asia.";
        }
    }
}