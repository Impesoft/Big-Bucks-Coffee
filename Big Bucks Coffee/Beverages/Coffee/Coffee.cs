using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Big_Bucks_Coffee
{
    internal class Coffee : Beverage
    {
        //  public typeOfCaffeine Caffeine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public Coffee()
        {
            HasMilk = false;
            Name = "Coffee";
            Price = 4.99;
            Image = "/Images/americano.jpg";
            Description = "Coffee is a brewed drink prepared from roasted coffee beans, the seeds of berries from certain Coffea species. When coffee berries turn from green to bright red in color – indicating ripeness – they are picked, processed, and dried. Dried coffee seeds are roasted to varying degrees, depending on the desired flavor.";
        }

        public override List<Control> CreateControls()
        {
            List<Control> test = new List<Control>();
            CheckBox CHasMilk = new CheckBox();
            //CHasMilk.Text = "Milk";
            //CHasMilk.Name = "CHasMilk";
            //CHasMilk.CheckedChanged += new System.EventHandler(this.SetControls);
            //test.Add(CHasMilk);

            //CheckBox CHasSugar = new CheckBox();
            //CHasSugar.Text = "Sugar";
            //CHasSugar.Name = "CHasSugar";
            //CHasSugar.CheckedChanged += new System.EventHandler(this.SetControls);
            //test.Add(CHasSugar);

            //ComboBox CCaffeine = new ComboBox();

            //foreach (var item in Enum.GetValues(typeof(typeOfCaffeine)))
            //{
            //    CCaffeine.Items.Add(item + " Caffeïne");
            //}
            //CCaffeine.SelectedIndex = 1;
            //CCaffeine.Name = "CCaffeine";
            //CCaffeine.TextChanged += new System.EventHandler(this.SetControls);
            //test.Add(CCaffeine);
            return test;
        }

        public virtual void SetControls(object sender, EventArgs e)
        {
            var x = sender as Control;
            //switch (x.Name)
            //{
            //    case "CHasMilk":
            //        HasMilk = ((CheckBox)x).Checked;
            //        break;

            //    case "CSugar":
            //        HasSugar = ((CheckBox)x).Checked;
            //        break;

            //    case "CCaffeine":
            //        Caffeine = (typeOfCaffeine)((ComboBox)x).SelectedIndex;
            //        break;
            //}
        }
    }
}