using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Bucks_Coffee
{
    internal class Coffee : IBeverage
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _naam;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Description { get; set; }
        public string ImageLocation { get; set; }

        public Coffee()
        {
        }
    }
}