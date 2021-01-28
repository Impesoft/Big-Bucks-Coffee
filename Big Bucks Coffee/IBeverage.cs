using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Bucks_Coffee
{
    public interface IBeverage
    {
        abstract int Id { get; set; }

        double Price { get; set; }
        string Naam { get; set; }
        string Description { get; set; }

        string ImageLocation { get; set; }

        void Beverage() { }

        string ToString();
    }
}