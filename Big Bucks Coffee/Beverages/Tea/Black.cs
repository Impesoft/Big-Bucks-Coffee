using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal class Black : Tea
    {
        public Black()
        {
            Name = "Black Tea";
            Price = 2.99;
            Image = "/Images/black.jpg";
            Description = "Black tea is a type of tea that is more oxidized than oolong, yellow, white and green teas. Black tea is generally stronger in flavor than other teas. All four types are made from leaves of the shrub Camellia sinensis.";
        }
    }
}