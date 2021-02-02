using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Big_Bucks_Coffee
{
    internal class Latte : _Espresso
    {
        //public typeOfRoast TypeOfRoast { get; set; }

        public Latte()
        {
            Name = "Latte";
            Price = 2.99;
            // Image = "espresso";
            Description = "Caffe latte(ˈlɑːteɪ / or / ˈlæteɪ /) is a coffee drink made with espresso and steamed milk.The word comes from the Italian caffè e latte , which means \"coffee & milk\". .";
        }
    }
}