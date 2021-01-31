using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Big_Bucks_Coffee
{
    internal class Espresso : Beverage
    {
        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public Espresso()
        {
            Name = "Espresso";
            Price = 2.99;
            Image = "/Images/espresso.jpg";
            Description = "Espresso is a coffee-brewing method of Italian origin, in which a small amount of nearly boiling water is forced under 9–10 bars of atmospheric pressure through finely-ground coffee beans. Espresso coffee can be made with a wide variety of coffee beans and roast degrees.";
        }

        public override List<Control> CreateControls()
        {
            HasMilk = false;
            List<Control> test = new List<Control>();
            CheckBox CHasMilk = new CheckBox();

            return test;
        }

        public virtual void SetControls(object sender, EventArgs e)
        {
            var x = sender as Control;
        }
    }
}