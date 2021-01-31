using System;
using System.IO;

namespace Big_Bucks_Coffee
{
    internal class Mint : Tea
    {
        //public typeOfTea TypeOfTea { get; set; }

        public Mint()
        {
            Name = "Mint Tea";
            Price = 2.99;
            Image = "/Images/mint.jpg";
            Description = "Mint tea is a herbal tea made by infusing mint leaves in hot water. Mint tea made with peppermint leaves is called peppermint tea, and mint tea made with spearmint is called spearmint tea.";
        }
    }
}