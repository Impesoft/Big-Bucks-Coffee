using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Bucks_Coffee
{
    internal class Strawberry : Milkshake
    {
        public bool IsFrozenFruit { get; set; }

        public Strawberry()
        {
            Name = "Strawberry Shake";
            Price = 5.99;
            Image = "/Images/strawberry.jpg";
            Description = "Who can resist Strawberry Milkshake? Look at is cute pinkness! See how tender it looks? I bet it will taste as sweet as my first kiss! Now the question is, with dairy or without?";
        }
    }
}