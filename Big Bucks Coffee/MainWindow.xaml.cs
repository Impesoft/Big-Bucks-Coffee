using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int aantalkeer = 5;
            string[] name = new string[5] { "Appels", "Peren", "Bananen", "Appelsienen", "Citroenen" };
            //   Content = ShowMyControl(aantalkeer);
            ShowMyControl(aantalkeer, name);
            foreach (var control in this.myWrap.Children)
            {
                UserControl1 myUserControl = control as UserControl1;

                if (myUserControl != null)
                {
                    myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
                }
            }
            //  this.Width = this.Width - (this.Width % 250);
        }

        //        private Grid ShowMyControl(int aantalkeer)
        private void ShowMyControl(int aantalkeer, string[] name)
        {
            for (int i = 0; i < aantalkeer; i++)
            {
                var g = new UserControl1
                {
                    Name = name[i],
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 420
                };
                g.ProductName.Content = name[i];
                g.Price.Content = $"Price: € {i * 5 + 1}";
                g.TextBox.Text = $"Hello {i} World";
                g.IsInStock.IsChecked = (i % 2 == 0);
                myWrap.Children.Add(g);
            }
        }

        private void AddToCartButtonClickedInUserControl(object sender, EventArgs e)
        {
            // Cast object class to MyUserClass
            UserControl1 myControl = sender as UserControl1;
            System.Windows.MessageBox.Show(myControl.ProductName.Content.ToString());
            //     int productId = myControl.PizzaID;
            //   AddProductToCart(productId);
        }

        private void AddProductToCart(int productId)
        {
            //   var pizza = _repo.GetPizza(productId);
            //    _cart.AddProductToCart(pizza);
        }

        private void MainGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //this.Width = this.Width - (this.Width % 250);
        }
    }
}