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
        // public typeOfRoast TypeOfRoast { get; set; }

        public Americano()

        {
            Name = "Americano";
            Price = 1.99;
            Image = "/Images/americano.jpg";
            Description = "Caffè Americano is a type of coffee drink prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from, traditionally brewed coffee.The strength of an Americano varies with the number of shots of espresso and the amount of water added.";
        }

        public override List<Control> CreateControls()
        {
            ComboBox CTypeOfRoast = new ComboBox
            {
                //foreach (var item in Enum.GetValues(typeof(typeOfRoast)))
                //{
                //    CTypeOfRoast.Items.Add(item + " Roast");
                //}

                SelectedIndex = 1
            };
            List<Control> test2 = base.CreateControls();
            CTypeOfRoast.Name = "CTypeOfRoast";
            //CTypeOfRoast.TextChanged += new System.EventHandler(this.SetControls);
            test2.Add(CTypeOfRoast);
            return test2;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            base.SetControls(sender, e);
            if ((sender as Control).Name == "CTypeOfRoast")
            {
                var x = sender as ComboBox;

                //TypeOfRoast = (typeOfRoast)((ComboBox)x).SelectedIndex;
            }
        }
    }
}