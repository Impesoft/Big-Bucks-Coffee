using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Controls;

namespace Big_Bucks_Coffee
{
    internal abstract class Beverage : IBeverage
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description { get; set; }

        private static int PID = 1;

        public string DefaultImage { get; set; }

        public int ID { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        protected Beverage()
        {
            ID = PID;
            PID++;
        }

        public override string ToString()
        {
            string result = $"{Price}, {Description}, {ID}, {Image}, {Name}";
            return result;
        }

        public virtual List<Control> CreateControls()
        {
            return null;
        }
    }
}