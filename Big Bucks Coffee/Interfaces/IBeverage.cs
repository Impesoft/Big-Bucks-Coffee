using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Big_Bucks_Coffee
{
    public interface IBeverage
    {
        double Price { get; set; }

        string Description { get; set; }

        int ID { get; set; }

        string Image { get; set; }

        string Name { get; set; }

        string ToString();

        List<Control> CreateControls();
    }
}