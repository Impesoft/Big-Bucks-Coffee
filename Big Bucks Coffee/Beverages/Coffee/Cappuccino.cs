using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal class Cappuccino : Coffee
    {
        public Cappuccino()
        {
            HasMilk = false;
            Name = "Cappuccino";
            Price = 4.99;
            Image = "/Images/cappuccino.jpg";
            Description = "A cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with steamed milk foam. Variations of the drink involve the use of cream instead of milk, using non-dairy milks, and flavoring with cinnamon or chocolate powder.";
        }
    }

    //int caffeine = 0, bool hasMilk = false, bool hasSugar = false
    //: base(caffeine, hasMilk, hasSugar)
}