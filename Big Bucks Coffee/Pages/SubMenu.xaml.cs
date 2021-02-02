using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Big_Bucks_Coffee
{
    /// <summary>
    /// Interaction logic for SubMenu.xaml
    /// </summary>
    public partial class SubMenu : Page
    {
        public SubMenu()
        {
            InitializeComponent();
            AddButtonClickEvents();
        }

        public void AddToCartButtonClicked()
        {
            MessageBox.Show("Test");
        }

        private void AddButtonClickEvents()
        {
            foreach (var control in this.myWrap.Children)
            {
                if (control is UserControl1 myUserControl)
                {
                    //myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
                    myUserControl.AddToCartButtonClicked += (s, e) =>
                    {
                        MessageBox.Show("Test");
                        UserControl1 myControl = s as UserControl1;
                        string selectedBeverage = myControl.Name.ToString();
                        //     AddProductToCart(StringtoBeverage(selectedBeverage));
                    };
                }
            }
        }
    }
}