using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Big_Bucks_Coffee
{
    internal class Americano : _Espresso
    {
        public Americano()

        {
            Name = "Americano";
            Price = 1.99;
            Image = "/Images/americano.jpg";
            Description = "Caffè Americano is a type of coffee drink prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from, traditionally brewed coffee.The strength of an Americano varies with the number of shots of espresso and the amount of water added.";
        }

        public override List<Control> CreateControls()
        {
            List<Control> control = base.CreateControls();
            return control;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            base.SetControls(sender, e);
            if ((sender as Control).Name == "CTypeOfRoast")
            {
                ComboBox x = sender as ComboBox;
            }
        }
    }
}