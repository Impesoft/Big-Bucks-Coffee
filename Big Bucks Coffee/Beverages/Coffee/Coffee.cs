using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Big_Bucks_Coffee
{
    internal class coffee : _Espresso
    {
        public coffee()
        {
            Name = "Coffee";
            Price = 4.99;
            Image = "/Images/americano.jpg";
            Description = "Coffee is a brewed drink prepared from roasted coffee beans, the seeds of berries from certain Coffea species. When coffee berries turn from green to bright red in color – indicating ripeness – they are picked, processed, and dried. Dried coffee seeds are roasted to varying degrees, depending on the desired flavor.";
        }
    }
}